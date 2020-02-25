using System;
using System.Collections.Generic;
using System.Text;

namespace PolarizeLab.Blazor.Redux
{
    public delegate void MiddlewareDelegate<TState>(Store<TState> state, object action, Dispatcher dispatcher) where TState : class;
    public class Middleware<TState> where TState : class
    {
        readonly MiddlewareDelegate<TState> Handler;
        public Middleware(MiddlewareDelegate<TState> handler)
        {
            Handler = handler;
        }

        public void Handle(Store<TState> store, object action, Dispatcher next)
        => Handler(store, action, next);
        public static implicit operator Middleware<TState>(MiddlewareDelegate<TState> middlewareDelegate)
        {
            return new Middleware<TState>(middlewareDelegate);
        }
    }
}

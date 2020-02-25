using Microsoft.AspNetCore.Components;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace PolarizeLab.Blazor.Redux
{
    public abstract class ReduxComponent<TState, TViewModel> : ComponentBase, IDisposable where TState : class
    {
        [Inject]
        protected Store<TState> Store { get; set; }
        protected abstract TViewModel ViewModel { get; }

        protected override sealed void OnInitialized()
        {
            OnRInitialized();
            Store.StateChanged += StateChanged;
        }
        public void Dispose()
        {
            Store.StateChanged -= StateChanged;
            OnRDestroy();
        }
        public virtual void OnRInitialized()
        {
            base.OnInitialized();
        }
        public virtual void OnRDestroy()
        {

        }
        private void StateChanged()
         => StateHasChanged();
    }
}

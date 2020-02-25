using System;
using System.Collections.Generic;
using System.Text;

namespace Polarizelab.Blazor.Redux
{
    public delegate TState Reducer<TState>(TState state, object action);
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Redux
{
    public delegate TState Reducer<TState>(TState state, object action);
}

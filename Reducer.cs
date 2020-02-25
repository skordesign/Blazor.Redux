using System;
using System.Collections.Generic;
using System.Text;

namespace PolarizeLab.Blazor.Redux
{
    public delegate TState Reducer<TState>(TState state, object action);
}

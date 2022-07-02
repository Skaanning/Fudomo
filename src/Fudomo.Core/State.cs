using System.Diagnostics.CodeAnalysis;

namespace Fudomo.Core;

public class State<T>
{
    private readonly T _t;
    private readonly List<string> _internalState = new();

    internal State([DisallowNull] T t)
    {
        _t = t ?? throw new ArgumentNullException(nameof(t));
    }
    
    
}
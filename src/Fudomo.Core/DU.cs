using System.Diagnostics.CodeAnalysis;

namespace Fudomo.Core;

// ReSharper disable once InconsistentNaming
public class DU<T0, T1>
{
    private readonly int _index;
    private readonly T0? _t0;
    private readonly T1? _t1;

    internal DU([DisallowNull] T0 t0)
    {
        _t0 = t0 ?? throw new ArgumentNullException(nameof(t0));
        _index = 0;
    }

    internal DU([DisallowNull] T1 t1)
    {
        _t1 = t1 ?? throw new ArgumentNullException(nameof(t1));
        _index = 1;
    }

    public T Unwrap<T>(Func<T0, T> f0, Func<T1, T> f1)
    {
        return _index == 0
            ? f0(_t0!)
            : f1(_t1!);
    }
    
    public DU<T0, T1> Do(Action<T0> f0, Action<T1> f1)
    {
        if (_index == 0) 
            f0(_t0!);
        else 
            f1(_t1!);

        return this;
    }
    
    public static implicit operator DU<T0, T1>(T0 t0) => new(t0!);
    public static implicit operator DU<T0, T1>(T1 t1) => new(t1!);
}

// ReSharper disable once InconsistentNaming
public class DU<T0, T1, T2>
{
    private readonly int _index;
    private readonly T0? _t0;
    private readonly T1? _t1;
    private readonly T2? _t2;

    internal DU([DisallowNull] T0 t0)
    {
        _t0 = t0 ?? throw new ArgumentNullException(nameof(t0));
        _index = 0;
    }

    internal DU([DisallowNull] T1 t1)
    {
        _t1 = t1 ?? throw new ArgumentNullException(nameof(t1));
        _index = 1;
    }

    internal DU([DisallowNull] T2 t2)
    {
        _t2 = t2 ?? throw new ArgumentNullException(nameof(t2));
        _index = 2;
    }

    public T Unwrap<T>(Func<T0, T> f0, Func<T1, T> f1, Func<T2, T> f2)
    {
        return _index switch
        {
            0 => f0(_t0!),
            1 => f1(_t1!),
            2 => f2(_t2!),
            var i => throw new Exception($"unknown DU of index {i}")
        };
    }
    
    public DU<T0, T1, T2> Do(Action<T0> f0, Action<T1> f1, Action<T2> f2)
    {
        switch (_index)
        {
            case 0: 
                f0(_t0!);
                break;
            case 1: 
                f1(_t1!);
                break;
            case 2:
                f2(_t2!);
                break;
        }

        return this;
    }
    
    public static implicit operator DU<T0, T1, T2>(T0 t0) => new(t0!);
    public static implicit operator DU<T0, T1, T2>(T1 t1) => new(t1!);
    public static implicit operator DU<T0, T1, T2>(T2 t2) => new(t2!);
}

// ReSharper disable once InconsistentNaming
public class DU<T0, T1, T2, T3>
{
    private readonly int _index;
    private readonly T0? _t0;
    private readonly T1? _t1;
    private readonly T2? _t2;
    private readonly T3? _t3;

    internal DU([DisallowNull] T0 t0)
    {
        _t0 = t0 ?? throw new ArgumentNullException(nameof(t0));
        _index = 0;
    }

    internal DU([DisallowNull] T1 t1)
    {
        _t1 = t1 ?? throw new ArgumentNullException(nameof(t1));
        _index = 1;
    }

    internal DU([DisallowNull] T2 t2)
    {
        _t2 = t2 ?? throw new ArgumentNullException(nameof(t2));
        _index = 2;
    }

    internal DU([DisallowNull] T3 t3)
    {
        _t3 = t3 ?? throw new ArgumentNullException(nameof(t3));
        _index = 3;
    }

    public T Unwrap<T>(
        Func<T0, T> f0, 
        Func<T1, T> f1, 
        Func<T2, T> f2,
        Func<T3, T> f3)
    {
        return _index switch
        {
            0 => f0(_t0!),
            1 => f1(_t1!),
            2 => f2(_t2!),
            3 => f3(_t3!),
            var i => throw new Exception($"unknown DU of index {i}")
        };
    }
    
    public DU<T0, T1, T2, T3> Do(Action<T0> f0, Action<T1> f1, Action<T2> f2,Action<T3> f3)
    {
        switch (_index)
        {
            case 0: 
                f0(_t0!);
                break;
            case 1: 
                f1(_t1!);
                break;
            case 2:
                f2(_t2!);
                break;
            case 3: 
                f3(_t3!);
                break;
        }
        return this;
    }
    
    public static implicit operator DU<T0, T1, T2, T3>(T0 t0) => new(t0!);
    public static implicit operator DU<T0, T1, T2, T3>(T1 t1) => new(t1!);
    public static implicit operator DU<T0, T1, T2, T3>(T2 t2) => new(t2!);
    public static implicit operator DU<T0, T1, T2, T3>(T3 t3) => new(t3!);
}

// ReSharper disable once InconsistentNaming
public class DU<T0, T1, T2, T3, T4>
{
    private readonly int _index;
    private readonly T0? _t0;
    private readonly T1? _t1;
    private readonly T2? _t2;
    private readonly T3? _t3;
    private readonly T4? _t4;

    internal DU([DisallowNull] T0 t0)
    {
        _t0 = t0 ?? throw new ArgumentNullException(nameof(t0));
        _index = 0;
    }

    internal DU([DisallowNull] T1 t1)
    {
        _t1 = t1 ?? throw new ArgumentNullException(nameof(t1));
        _index = 1;
    }

    internal DU([DisallowNull] T2 t2)
    {
        _t2 = t2 ?? throw new ArgumentNullException(nameof(t2));
        _index = 2;
    }

    internal DU([DisallowNull] T3 t3)
    {
        _t3 = t3 ?? throw new ArgumentNullException(nameof(t3));
        _index = 3;
    }

    internal DU([DisallowNull] T4 t4)
    {
        _t4 = t4 ?? throw new ArgumentNullException(nameof(t4));
        _index = 4;
    }

    public T Unwrap<T>(
        Func<T0, T> f0, 
        Func<T1, T> f1, 
        Func<T2, T> f2,
        Func<T3, T> f3,
        Func<T4, T> f4)
    {
        return _index switch
        {
            0 => f0(_t0!),
            1 => f1(_t1!),
            2 => f2(_t2!),
            3 => f3(_t3!),
            4 => f4(_t4!),
            var i => throw new Exception($"unknown DU of index {i}")
        };
    }
    
    public DU<T0, T1, T2, T3, T4> Do(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4)
    {
        switch (_index)
        {
            case 0: 
                f0(_t0!);
                break;
            case 1: 
                f1(_t1!);
                break;
            case 2:
                f2(_t2!);
                break;
            case 3: 
                f3(_t3!);
                break;
            case 4: 
                f4(_t4!);
                break;
        }
        
        return this;
    }
    
    public static implicit operator DU<T0, T1, T2, T3, T4>(T0 t0) => new(t0!);
    public static implicit operator DU<T0, T1, T2, T3, T4>(T1 t1) => new(t1!);
    public static implicit operator DU<T0, T1, T2, T3, T4>(T2 t2) => new(t2!);
    public static implicit operator DU<T0, T1, T2, T3, T4>(T3 t3) => new(t3!);
    public static implicit operator DU<T0, T1, T2, T3, T4>(T4 t4) => new(t4!);
}
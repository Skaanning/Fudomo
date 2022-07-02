using System.Diagnostics.CodeAnalysis;

namespace Fudomo.Core;

public static class Option
{
    public static Option<T> Some<T>(T t) => Option<T>.Some(t);
    public static Option<T> None<T>() => Option<T>.None;
}

public class Option<T>
{
    private readonly T? _some;
    private readonly bool _isNone;

    internal static Option<T> None => new();
    internal static Option<T> Some(T t) => new(t!);

    private Option([DisallowNull] T some)
    {
        _some = some ?? throw new ArgumentNullException(nameof(some));
    }

    private Option()
    {
        _isNone = true;
    }

    public TU Unwrap<TU>(Func<T, TU> fSome, Func<TU> fNone)
    {
        return _isNone
            ? fNone()
            : fSome(_some!);
    }
    
    public static implicit operator Option<T>(T some) => new(some!);
    
    public Option<T1> Select<T1>(Func<T, T1> f)
    {
        return Unwrap(
            x => Option.Some(f(x)!), 
            Option.None<T1>);
    }

    public Option<T1> Bind<T1>(Func<T, Option<T1>> f)
    {
        return Unwrap(
            f, 
            Option.None<T1>);
    }
    
    public Option<T> Do(Action<T> someAction, Action noneAction)
    {
        if (_isNone)
            noneAction();
        else
            someAction(_some!);

        return this;
    }
    
    public Result<T> ToResult(string errMsg)
    {
        return Unwrap(
            Result<T>.Success,
            () => Result<T>.Failure(errMsg));
    }
}
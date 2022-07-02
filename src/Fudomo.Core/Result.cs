namespace Fudomo.Core;

public static class Result
{
    public static Result<T> Success<T>(T t) => Result<T>.Success(t);
    public static Result<T> Failure<T>(string s) => Result<T>.Failure(s);
}

public class Result<T>
{
    private readonly T? _value;
    private readonly string? _errMsg;
    private readonly bool _isSuccess;

    private Result(T value)
    {
        _value = value;
        _isSuccess = true;
    }

    private Result(string errMsg)
    {
        _errMsg = errMsg;
        _isSuccess = false;
    }

    public Option<T> GetValue => _isSuccess ? _value! : Option<T>.None; 
    internal static Result<T> Success(T t) => new(t!); 
    internal static Result<T> Failure(string errMsg) => new(errMsg);

    public Result<T> Do(Action<T> f0, Action<string> f1)
    {
        if (_isSuccess) 
            f0(_value!);
        else 
            f1(_errMsg!);

        return this;
    }

    public TU Unwrap<TU>(Func<T, TU> f, Func<string, TU> fs)
    {
        return _isSuccess
            ? f(_value!)
            : fs(_errMsg!);
    }

    public Result<TU> Bind<TU>(Func<T, Result<TU>> f)
    {
        return Unwrap(
            f, 
            Result<TU>.Failure);
    }
    
    public Result<TU> Select<TU>(Func<T, TU> f)
    {
        return Unwrap(
            x => Result<TU>.Success(f(x)), 
            Result<TU>.Failure);
    }
    
    public static implicit operator Result<T>(T t) => new(t!);
    public static implicit operator Result<T>(string t1) => new(t1!);
}
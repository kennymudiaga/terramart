using FluentValidation.Results;

namespace TerraMart.Domain;

public class Result
{
    public Result()
    {
        Errors = new List<string>();
    }

    protected Result(bool success, List<string> errors)
    {
        Success = success;
        Errors = errors;
    }

    public bool Success { get; set; }
    public List<string> Errors { get; set; }

    public static Result Error(string error) => new(false, new() { error });
    public static Result Error(IEnumerable<string> errors) => new(false, errors.ToList());
    
    public static Result Ok() => new() { Success = true };
}

public class Result<T> : Result
{
    public Result() : base() { }
    public Result(T data, IEnumerable<string>? errors = null)
    {
        Success = true;
        Data = data;
        Errors = errors?.ToList() ?? new();
    }

    public Result(T data, string error) : base()
    {
        Success = true;
        Data = data;
        Errors.Add(error);
    }

    public T? Data { get; set; }
    public static Result Ok(T data, IEnumerable<string>? errors = null) => new Result<T>(data, errors);
    public static Result Ok(T data, string error) => new Result<T>(data, error);

    public static implicit operator Result<T>(ErrorResult result) => new() { Errors = result.Errors };
}

public class ErrorResult : Result
{
    public ErrorResult(string error): base()
    {
        Errors.Add(error);
    }

    public ErrorResult(IEnumerable<string> errors) : base(false, errors.ToList()) { }

    public ErrorResult(List<ValidationFailure> failures) : base()
    {
        Errors.AddRange(failures.Select(x => x.ErrorMessage));
    }
}


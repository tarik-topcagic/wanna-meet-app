namespace API.Errors;

public class ApiException(int statusCode, string message, string? details) 
{
    // private string v;

    // public ApiException(int statusCode, string v)
    // {
    //     StatusCode = statusCode;
    //     this.v = v;
    // }

    public int StatusCode { get; set; } = statusCode;
    public string Message { get; set; } = message;
    public string? Details { get; set; } = details;

}
using System.Net;
using System.Text.Json;

namespace Statistics.API.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            int internalServerErrorCode = 500;

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = internalServerErrorCode;

            string result = JsonSerializer.Serialize(new
            {
                error = new { code = internalServerErrorCode, message = ex.Message }
            });

            return context.Response.WriteAsync(result);
        }
    }
}

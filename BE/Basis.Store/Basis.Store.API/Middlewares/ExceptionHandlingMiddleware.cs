using Basis.Store.Application.Common.Interfaces;
using Basis.Store.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;

namespace Basis.Store.API.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerService loggerService;

        public ExceptionHandlingMiddleware(
            RequestDelegate next,
            ILoggerService loggerService)
        {
            _next = next;
            this.loggerService = loggerService;
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

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            var statusCode = HttpStatusCode.InternalServerError;
            var errorResponse = new
            {
                title = "Internal Server Error",
                message = "Ocorreu um erro interno no servidor"
            };

            if (exception is BusinessValidationException validationException)
            {
                statusCode = HttpStatusCode.BadRequest;
                errorResponse = new
                {
                    title = "Falha na validação de dados",
                    message = validationException.Message
                };
                loggerService.LogDebug(validationException, "Ocorreu uma validação de dados {Message}", validationException.Message);
            }
            else
            {
                loggerService.LogError(exception, "Um erro não tratado foi capturado: {Message} ", exception.Message);
            }

            context.Response.StatusCode = (int)statusCode;
            return context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
        }
    }
}
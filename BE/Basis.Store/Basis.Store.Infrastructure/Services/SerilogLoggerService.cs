using Basis.Store.Application.Common.Interfaces;
using Serilog;

namespace Basis.Store.Infrastructure.Services
{
    public class SerilogLoggerService : ILoggerService
    {
        private readonly ILogger logger;

        public SerilogLoggerService()
        {
            logger = Log.Logger;
        }

        public void LogDebug(string message, params object[] args)
        {
            logger.Debug(message, args);
        }

        public void LogDebug(Exception exception, string message, params object[] args)
        {
            logger.Debug(exception, message, args);
        }

        public void LogError(Exception exception, string message, params object[] args)
        {
            logger.Error(exception, message, args);
        }

        public void LogInformation(string mensagem, params object[] args)
        {
            logger.Information(mensagem, args);
        }

        public void LogWarning(string message, params object[] args)
        {
            logger.Warning(message, args);
        }
    }
}

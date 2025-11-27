namespace Basis.Store.Application.Common.Interfaces
{
    public interface ILoggerService
    {
        void LogDebug(string message, params object[] args);
        void LogDebug(Exception exception, string message, params object[] args);
        void LogInformation(string mensagem, params object[] args);
        void LogWarning(string message, params object[] args);
        void LogError(Exception exception, string message, params object[] args);

    }
}

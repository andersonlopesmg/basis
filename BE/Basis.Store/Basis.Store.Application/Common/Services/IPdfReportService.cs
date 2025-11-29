namespace Basis.Store.Application.Common.Services
{
    public interface IPdfReportService
    {
        byte[] GerarRelatorioPdf<T>(string reportPath, string dataSourceName, IEnumerable<T> data);
    }
}

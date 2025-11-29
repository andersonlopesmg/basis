using AspNetCore.Reporting;
using Basis.Store.Application.Common.Services;
using System.Text;

namespace Basis.Store.Infrastructure.Services
{
    public class RdlcReportService : IPdfReportService
    {
        public RdlcReportService()
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public byte[] GerarRelatorioPdf<T>(string reportPath, string dataSourceName, IEnumerable<T> data)
        {
            // 1. Localizar o arquivo .rdlc
            // Assumimos que os relatórios estão na pasta "Reports" dentro do diretório de execução
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var path = Path.Combine(basePath, reportPath);

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Relatório não encontrado em: {reportPath}");
            }

            // 2. Configurar o LocalReport
            var report = new LocalReport(path);

            // 3. Adicionar os dados
            report.AddDataSource(dataSourceName, data);

            // 4. Renderizar
            var result = report.Execute(RenderType.Pdf);

            return result.MainStream;
        }
    }
}
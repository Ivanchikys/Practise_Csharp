using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ReportManager<T>
    {
        private ReportRepository<T> repository;
        public ReportManager()
        {
            repository = new ReportRepository<T>();
        }

        public void CreateAndSaveReport(T data, string filename)
        {
            IReport<T> report = new TextReport<T>();
            string content = report.Generate(data);
            SaveReport(content, filename);
            repository.AddReport(report);
        }

        public void SaveReport(string report, string filename)
        {
            File.WriteAllText(filename, report);
            Console.WriteLine($"Отчёт сохранен {filename}");
        }
    }
}

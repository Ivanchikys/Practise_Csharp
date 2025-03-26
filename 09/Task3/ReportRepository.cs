using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ReportRepository<T>
    {
        private List<IReport<T>> reports = new List<IReport<T>>();
        public void AddReport(IReport<T> report)
        {
            reports.Add(report);
        }
        public void RemoveReport(IReport<T> report)
        {
            reports.Remove(report);
        }
        public IEnumerable<IReport<T>> GetAllReports()
        {
            return reports;
        }
    }
}

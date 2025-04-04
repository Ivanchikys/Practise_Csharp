using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class AttendanceRecord
    {
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public bool IsPresent { get; set; }
        public string Reason { get; set; }
    }
}

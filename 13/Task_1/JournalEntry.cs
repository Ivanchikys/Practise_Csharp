using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class JournalEntry
    {
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public int? Grade { get; set; }
        public string Comment { get; set; }
        public bool IsPresent { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkingSystem.Models
{
    class HistoryViewModel
    {
        public int historyId { get; set; }
        public int moduleId { get; set; }
        public DateTime historyDate { get; set; }
        public string historyDescription { get; set; }
        public string historyStatus { get; set; }
    }
}

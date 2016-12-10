using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkingSystem.Models
{
    class ModuleViewModel
    {
        public int ModuleId { get; set; }     
        public string Name { get; set; }
        public string Code { get; set; }
        public string ModuleStatus { get; set; }
        public int Semester { get; set; }
        public int SemesterYear { get; set; }
        public int CohortId { get; set; }
    }
}

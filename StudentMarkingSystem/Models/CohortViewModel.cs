using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkingSystem.Models
{
    public class CohortViewModel
    {
        public int CohortId { get; set; }
        public int ProgramId { get; set; }
        public string Cohort { get; set; }
        public string CohortStatus { get; set; }
    }
}

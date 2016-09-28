using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkingSystem.Models
{
    class StudentViewModel
    {
        public int StudentId { get; set; }
        public int CohortId { get; set; }

        public string IndexNo { get; set; }
        public string StudentFirstname { get; set; }
        public string StudentLastname { get; set; }
        public string StudentEmail { get; set; }
        public string StudentAddress { get; set; }
        public int StudentContact { get; set; }
        public string StudentStatus { get; set; }


    }
}

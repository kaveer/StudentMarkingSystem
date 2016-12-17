using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkingSystem.Models
{
    class GradeViewModel
    {
        public int gradeId { get; set; }
        public int moduleId { get; set; }
        public int studentId { get; set; }
        public int userId { get; set; }
        public decimal grade { get; set; }
        public string gradeStatus { get; set; }

    }
}

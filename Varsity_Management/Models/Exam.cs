using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Varsity_Management.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Exam_Name { get; set; }
        public string Subject { get; set; }
        public string Mark { get; set; }
        public string Grade { get; set; }
        public string Session { get; set; }
        public ICollection<StudentAssingExam> StudentResults { get; set; }

    }

   
}
  
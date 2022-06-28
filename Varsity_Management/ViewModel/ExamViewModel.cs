using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Varsity_Management.ViewModel
{
    public class ExamViewModel
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public string Exam_Name { get; set; }
        public string Subject { get; set; }
        public string Mark { get; set; }
        public string Grade { get; set; }
        public string Session { get; set; }
        public string Class { get; set; }
    }


    
}

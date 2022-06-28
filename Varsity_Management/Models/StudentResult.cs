using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Varsity_Management.Models
{
    public class StudentAssingExam
    {
        public int Id { get; set; }
        public int classManagementId { get; set; }
        public Class_management classManagement { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
       
        
    }
}
 
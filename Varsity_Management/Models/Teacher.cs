using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Varsity_Management.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Education_Result { get; set; }
        public string Grade { get; set; }
        public string Subject { get; set; }

    }

    public enum Grade
    {
        A, B, C, D
    }
}

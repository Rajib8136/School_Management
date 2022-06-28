using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Varsity_Management.Models
{
    public class Class_management
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string Number_Student { get; set; }
        public ICollection<Asign> Asign { get; set; }
    }

    public enum Class
    {
        Class_1, Class_2, Class_3, Class_4, Class_5, Class_6, Class_7, Class_8, Class_9, Class_10, Class_11
    }
    public enum Section
    {
        Section_A, Section_B, Section_C, Section_D
    }
}

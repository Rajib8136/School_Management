using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Varsity_Management.Models
{
    public class Asign
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public Class_management class_Management { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
    }
}

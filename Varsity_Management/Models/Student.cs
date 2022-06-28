using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Varsity_Management.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_name { get; set; }
        public string Full_Name { get; set; }
        public string Father_Name { get; set; }
        public string Mother_Name { get; set; }
        public string Mobile_Number { get; set; }
        public string Address { get; set; }
        public string Thana { get; set; }
        public string District { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public Gender Gender { get; set; }
        public Religions Religions { get; set; }
        public string Nationlity { get; set; }
        public string Id_card { get; set; }
        public string Identification { get; set; }
        public string Description { get; set; }

        public int? Class_managementId { get; set; }
        public Class_management Class_management { get; set; }
        public ICollection<StudentAssingExam> StudentResults { get; set; }
        public ICollection<Asign> Asigns { get; set; }
    }

    public enum Gender
    {
        male, Female, Both
    }
    public enum Religions
    {
        Islam, Hindu, Buddha, Christian
    }
    public enum Nationlity
    {
        Bangladesh, India, Usa , England 
    }
}

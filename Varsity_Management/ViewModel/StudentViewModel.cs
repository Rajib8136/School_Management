using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Varsity_Management.ViewModel
{
    public class StudentViewModel
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
        public int ExamId { get; set; }
        public int SubId { get; set; }
        public int GradeId { get; set; }
        public int SessionId { get; set; }
        public int MarkId { get; set; }
        public List<ClassViewModel> ClassViewModels { get; set; }
        public List<ExamViewModel> ExamViewModels { get; set; }
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
        Bangladesh, India, Usa, England
    }
}


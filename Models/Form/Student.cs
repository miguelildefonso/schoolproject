using System;
namespace SchoolProject.Models.Form
{
    public class Student
    {
        public Int32 student_id{get; set;}
        public string firstname{get; set;}
        public string middlename{get; set;}
        public string lastname{get; set;}
        public DateTime birthday{get; set;}
        public string program{get; set;}
        public string status{get; set;}
        public string sem{get; set;}
        public Int32 yearlevel {get; set;}
        public Int32 academic_year{get; set;}
        public string username{get; set;}
        public string password{get; set;}
    }

    public enum StudStatus
    {        
        Regular, Irregular
    }

    public enum Stud_Program
    {        
        Computer_Science, Information_Technology, Tourism_Management,
        Hospitality_Management, Office_Administration
    }

    public enum Sem
    {
        First, Second
    }
}
using System;

namespace SchoolProject.Models.Form
{
    public class Professor
    {
        public Int32 professor_id{get;set;}
        public Int32 professor_no{get;set;}
        public string professor_name{get;set;}
        public char gender{get;set;}
        public string status{get;set;}
        public DateTime birthdate{get;set;}
        public string username{get;set;}
        public string password{get;set;}
    }

    public enum Gender
    {
        M, F    
    }
    public enum Status
    {
        Professor,
        Assitant_Professor, 
        Associate_Professor,
        Visiting_Professor
    }
}
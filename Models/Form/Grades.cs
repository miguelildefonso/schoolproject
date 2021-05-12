using System;
namespace SchoolProject.Models.Form
{
    public class Grades
    {
        public Int32 grade_id{get;set;}
        public Int32 student_id{get;set;}
        public string subject_title{get;set;}
        public Double grade{get;set;}
        public string comment{get;set;}
        public DateTime date_modified{get;set;}
        public string remarks{get;set;}
    }
    public enum Remarks
    {
        Passed, Failed   
    }
}
using System;
namespace SchoolProject.Models.Form
{
    public class Attendance
    {
        public Int32 attendance_id{get;set;}
        public DateTime date{get;set;}
        public string subject_code{get;set;}
        public Int32 student_id{get;set;}
        public string comment{get;set;}
    }

    public enum Comment
    {
        Present, Absent
    }
}
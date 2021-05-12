using System;
using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models.Data
{
    [Table]
    public class Attendance
    {
        [Key]
        public Int32 attendance_id{get;set;}
        [Column]
        public DateTime date{get;set;}
        [Column]
        public string subject_code{get;set;}
        [Column]
        public Int32 student_id{get;set;}
        [Column]
        public string comment{get;set;}
    }
}
using System;
using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models.Data
{
    [Table]
    public class Student
    {
        [Key]
        public Int32 student_id{get; set;}
        [Column]
        public string firstname{get; set;}
        [Column]
        public string middlename{get; set;}
        [Column]
        public string lastname{get; set;}
        [Column]
        public DateTime birthday{get; set;}
        [Column]
        public string program{get; set;}
        [Column]
        public string status{get; set;}
        [Column]
        public string sem{get; set;}
        [Column]
        public Int32 yearlevel {get; set;}
        [Column]
        public Int32 academic_year{get; set;}
        [Column]
        public string username{get; set;}
        [Column]
        public string password{get; set;}
    }
}
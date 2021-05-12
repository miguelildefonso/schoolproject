using System; 
using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;
namespace SchoolProject.Models.Data
{
    [Table]
    public class Grades
    {
        [Key]
        public Int32 grade_id{get;set;}
        [Column]
        public Int32 student_id{get;set;}
        [Column]
        public string subject_title{get;set;}
        [Column]
        public Double grade{get;set;}
        [Column]
        public string comment{get;set;}
        [Column]
        public DateTime date_modified{get;set;}
        [Column]
        public string remarks{get;set;}

    }
}
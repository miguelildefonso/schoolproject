using System; 
using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;
namespace SchoolProject.Models.Data
{
    [Table]
    public class Subject
    {
        [Key]
        public Int32 subject_id{get;set;}
        [Column]
        public string subject_code{get;set;}
        [Column]
        public string subject_title{get;set;}
        [Column]
        public Int32 units{get;set;}
       
    }
}
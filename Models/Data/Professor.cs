using System;
using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models.Data
{
    [Table]
    public class Professor
    {
        [Key]
        public Int32 professor_id{get;set;}
        [Column]
        public Int32 professor_no{get;set;}
        [Column]
        public string professor_name{get;set;}
        [Column]
        public char gender{get;set;}
        [Column]
        public string status{get;set;}
        [Column]
        public DateTime birthdate{get;set;}
        [Column]
        public string username{get;set;}
        [Column]
        public string password{get;set;}
    }
}
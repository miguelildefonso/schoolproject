using System;
using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models.Data
{
    [Table]
    public class Programs
    {
        [Key]
        public Int32 program_id{get;set;}
        [Column]
        public string program_code{get;set;}
        [Column]
        public string program_title{get;set;}
        [Column]
        public string major{get;set;}
    }
}
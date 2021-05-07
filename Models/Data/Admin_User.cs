using System;
using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models.Data
{
    [Table]
    public class Admin_User
    {
        [Key]
        public Int32 admin_id {get; set;}
        [Column]
        public string username {get; set;}
        [Column]
        public string password {get; set;}
        [Column]
        public string firstname {get; set;}
        [Column]
        public string lastname {get; set;}
        [Column]
        public string type {get; set;}
    }
}
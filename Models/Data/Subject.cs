using System; 
namespace SchoolProject.Models.Data
{
    public class Subject
    {
        Int32 Subject_id{get;set;}
        string Subject_code{get;set;}
        string Subject_title{get;set;}
        Int32 Units{get;set;}
        string Prerequisite{get;set;}
        string Active_deactive{get;set;}
    }
}
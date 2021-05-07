using System; 
namespace SchoolProject.Models.Data
{
    public class Grades
    {
        Int32 Grade_id{get;set;}
        Int32 Session_id{get;set;}
        Double Grade{get;set;}
        string Comment{get;set;}
        DateTime Date_modified{get;set;}
        string Remarks{get;set;}
        string Status{get;set;}
    }
}
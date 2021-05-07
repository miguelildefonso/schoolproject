using System;
namespace SchoolProject.Models.Data
{
    public class T_Subject_Detail_History
    {
        Int32 Session_id{get;set;}
        Int32 Professor_id{get;set;}
        Int32 Subject_id{get;set;}
        Int32 Academic_year{get;set;}
        Int32 Sem{get;set;}
        string Schedule{get;set;}
        string Section{get;set;}
        Int32 Yearlevel{get;set;}
        string Status{get;set;}
        string Active_deactive{get;set;}
    }
}
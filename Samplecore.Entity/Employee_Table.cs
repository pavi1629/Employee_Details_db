// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Samplecore.Entity
{
    public partial class Employee_Table
    {
        public object Repassword;

        public int Employee_Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string Gender { get; set; }
        public long? Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long? Password { get; set; }
        public long? Retype_Password { get; set; }
        public bool Is_Deleted { get; set; }
        public DateTime Created_Time_Stamp { get; set; }
        public DateTime Updated_Time_Stamp { get; set; }
    }
}
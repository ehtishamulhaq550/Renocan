//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Renocan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin_Signup
    {
        public int Admin_ID { get; set; }
        public string Admin_Name { get; set; }
        public string Admin_Designation { get; set; }
        public Nullable<int> Admin_Employee_ID { get; set; }
        public string Admin_Contact_Number { get; set; }
        public string Admin_Address { get; set; }
        public Nullable<int> User_CategoryId { get; set; }
        public string Admin_Password { get; set; }
        public string Creation_By { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public string Updated_By { get; set; }
        public Nullable<System.DateTime> Updated_Date { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public byte[] Ip { get; set; }
    }
}

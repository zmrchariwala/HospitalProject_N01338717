using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HospitalProject_N01338717.Models
{
    public class Registration
    {
        [Key]

        public int userid { get; set; }
        public string userfirstname { get; set; }
        public string usermiddlename { get; set; }
        public string userlastname { get; set; }
        public string userdob { get; set; }
        public string useremailaddress { get; set; }
        public string userphone { get; set; }
        public string userpassword { get; set; }
        public string userrole { get; set; }
    }
}
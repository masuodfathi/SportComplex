﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCUser.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TblUser
    {
        public int ID { get; set; }
        [Display(Name ="نام")]
        public string fname { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string lname { get; set; }
        [Display(Name = "سن")]
        public Nullable<int> age { get; set; }
    }
}

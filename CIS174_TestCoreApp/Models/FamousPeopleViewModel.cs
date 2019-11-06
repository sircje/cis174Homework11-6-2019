﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class FamousPeopleViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Key]
        [Display(Name = "ID")]
        public int FamousPeopleId { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Birthdate")]
        public string birthDate { get; set; }
        [Required]
        [Display(Name = "City")]
        public string city { get; set; }
        [Required]
        [Display(Name = "State")]
        public string state { get; set; }
        [Required]
        public DateTime LastModified { get; set; }
        public List<Achievements> Achievements = new List<Achievements>
        {
        };
    }
}

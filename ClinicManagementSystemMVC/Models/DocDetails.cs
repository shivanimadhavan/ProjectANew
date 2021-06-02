﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemMVC.Models
{
    public class DocDetails
    {
       

        [Key]
        public int DoctorID { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Sex { get; set; }
        [Range(1, 120, ErrorMessage = "Age must be between 1-120 in years.")]
        public int Age { get; set; }
        //[DisplayName("Birthdate")]
        //[DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public Nullable<System.DateTime> Date_of_Birth { get; set; }
        [Required]
        public DSpecialization Specialization { get; set; }


       
      [Display(Name="From Time")]
        [DataType(DataType.Time)]
        public DateTime FromTime { get; set; }
        [Display(Name = "To Time")]
        [DataType(DataType.Time)]
        public DateTime ToTime { get; set; }


        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
    }
    public enum DSpecialization
    {
        General, Gynaecologist, Pediatrics, Orthopedics, Ophthalmology
    }
}
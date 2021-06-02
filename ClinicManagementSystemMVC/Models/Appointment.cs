using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemMVC.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public int PatientID { get; set; }
        public ASpecializationRequired SpecializationRequired { get; set; }
        [Required]
        public string DoctorName { get; set; }

        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        [Display(Name = "Visit Date")]
        public string VisitDate { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Visit Time")]
        public DateTime VisitTime { get; set; }
    }
    public enum ASpecializationRequired
    {
        General, Gynaecologist, Pediatrics, Orthopedics, Ophthalmology
    }
}
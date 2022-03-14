using System;
using System.Collections.Generic;

namespace FullClinicMnagementsystem.Models
{
    public partial class PatientMedInfo
    {
        public int? PatientNo { get; set; }
        public double? PatientWeight { get; set; }
        public string? BloodPressure { get; set; }
        public string? Cholestrol { get; set; }
        public string? Sugar { get; set; }
        public string? MedicineSubscribed { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public DateTime? NextAppointment { get; set; }
        public int? Amount { get; set; }
        public int MedInfoId { get; set; }

        public virtual Patient? PatientNoNavigation { get; set; }
    }
}

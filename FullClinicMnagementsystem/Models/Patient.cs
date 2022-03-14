using System;
using System.Collections.Generic;

namespace FullClinicMnagementsystem.Models
{
    public partial class Patient
    {
        public Patient()
        {
            PatientMedInfos = new HashSet<PatientMedInfo>();
        }

        public int PatientNo { get; set; }
        public string PatientName { get; set; } = null!;
        public string PatientMobNo { get; set; } = null!;

        public virtual ICollection<PatientMedInfo> PatientMedInfos { get; set; }
    }
}

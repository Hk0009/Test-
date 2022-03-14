using System;
using System.Collections.Generic;

namespace FullClinicMnagementsystem.Models
{
    public partial class Department1
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int Capctay { get; set; }
    }
}

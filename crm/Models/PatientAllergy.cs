using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Models
{
    public class PatientAllergy
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int AllergyId { get; set; }
        public Allergy Allergy { get; set; }
    }
}

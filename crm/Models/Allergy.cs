using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Models
{
    public class Allergy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<PatientAllergy> PatientAllergies { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class InsuranceCompany
    {
        [Key]
        public string InsuranceCompanyID { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string InsuranceCompanyAddress { get; set; }
        public string InsuranceCompanyAddressRegion { get; set; }
        public string InsuranceCompanyAddressCity { get; set; }
        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; set; }
    }
}

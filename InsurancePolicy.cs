using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class InsurancePolicy
    {
        [Key]
        public int InsuranceID { get; set; }
        [ForeignKey("InsuranceCompany")]
        public int InsuranceCompanyID { get; set; }
        [ForeignKey("Cars")]
        public int CarID { get; set; }
        public DateTime PolicyStartDay { get; set; }
        public DateTime PolicyExpiryDate { get; set; }
        public virtual InsuranceCompany InsuranceCompany { get; set; }
        public virtual Cars Cars { get; set; }

    }
}

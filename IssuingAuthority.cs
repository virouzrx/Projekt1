using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class IssuingAuthority
    {
        [Key]
        public int IssuingAuthorityID { get; set; }
        public string IssuingAuthorityName { get; set; }
        public string IssuingAuthorityAddress { get; set; }
        public string IssuingAuthorityAddressRegion { get; set; }
        public string IssuingAuthorityAddressCity { get; set; }
        public virtual ICollection<DrivingLicense> DrivingLicences { get; set; }
        public virtual ICollection<CarDocs> CarDocs { get; set; }
    }
}

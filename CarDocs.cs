using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class CarDocs
    {
        [Key]
        public int CarDocsID { get; set; }
        [ForeignKey("Car")]
        public int CarID { get; set; }
        [ForeignKey("IssuingAuthority")]
        public int IssuingAuthorityID { get; set; }
        public string CarCardNumber { get; set; }
        public DateTime FirstRegistrationDate { get; set; }
        public string LogbookNumber { get; set; } 
        public string LicensePlateNumber { get; set; } 
        public virtual Cars Car { get; set; }
        public IssuingAuthority IssuingAuthority { get; set; }

    }
}

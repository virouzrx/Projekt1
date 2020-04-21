using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekt2
{
    class Cars
    {
        [Key]
        public int CarID { get; set; }
        public int DriverID { get; set; }
        public Drivers Driver { get; set; }
        public InsurancePolicy InsurancePolicy { get; set; }
        public virtual CarDocs CarDocs { get; set; } 
        public virtual CarData CarData { get; set; } 
        public virtual CarSpecs CarSpecs { get; set; }
        public virtual ICollection<TechnicalReview> TechnicalReviews { get; set; }
    }
}

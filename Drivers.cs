using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Drivers
    {
        [Key]
        public int DriverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Region { get; set; }
        public int PESEL { get; set; } 
        public virtual DrivingLicense DrivingLicense { get; set; }
        public virtual ICollection<Cars> Cars { get; set; }
    }
}

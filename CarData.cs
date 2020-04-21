using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class CarData
    {
    [ForeignKey("Car")]
    public int CarID { get; set; }
    public string CarModel { get; set; }
    public string CarCompany { get; set; }
    public int VinNumber { get; set; }
    public virtual Cars Car { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class CarSpecs
    {
        [ForeignKey("Car")] //<-nazwa musi być taka sama
        public int EnginePower { get; set; }
        public int EngineCapacity { get; set; }
        public int SeatAmount { get; set; }
        public int CarMass { get; set; } 
        public virtual Cars Car { get; set; }//<-jak tu?



    }
}

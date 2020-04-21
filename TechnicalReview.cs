using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class TechnicalReview
    {
        [Key]
        public int TechnicalReviewID { get; set; }
        [ForeignKey("Car")]
        public int CarID { get; set; } 
        [ForeignKey("TechnicalReviewStation")]
        public int TechnicalReviewStationID { get; set; }
        public DateTime TechnicalReviewDate { get; set; }
        public DateTime TechnicalReviewExpiryDate { get; set; }
        public bool TechnicalReviewStatus { get; set; }
        public Cars Car { get; set; }
        public TechnicalReviewStation TechnicalReviewStation { get; set; }

    }
}

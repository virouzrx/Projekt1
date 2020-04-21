using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class TechnicalReviewStation
    {
        [Key]
        public int TechnicalReviewStationID { get; set; }
        public string TechnicalReviewStationOwnerFirstName { get; set; }
        public string TechinalReviewStationOwnerLastName { get; set; }
        public string TechnicalReviewStationAddress { get; set; }
        public string TechnicalReviewStationAddressCity { get; set; }
        public string TechnicalReviewStationAddressRegion { get; set; }
        public virtual ICollection<TechnicalReview> TechnicalReviews { get; set; }

    }
}

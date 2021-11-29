using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public class Guest:BaseModel
    {
        public User User { get; set; }
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("User")]
        public new int ID { get; set; }

        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual ICollection<GuestReviewHotel> GuestReviewHotels { get; set; }
    }
}

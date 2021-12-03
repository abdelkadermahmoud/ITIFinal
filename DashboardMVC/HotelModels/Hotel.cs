using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public class Hotel :BaseModel
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public string CheckInTime { get; set; }
        public string CheckOutTime { get; set; }
        public bool IsActive { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public Meal Meal { get; set; }
        [ForeignKey("Meal")]
        public int Meal_Id { get; set; }
        public Partner Partner { get; set; }
        [ForeignKey("Partner")]
        public int Partner_Id{ get; set; }
        public City City { get; set; }
        [ForeignKey("City")]
        public int City_Id{ get; set; }
        public Cancelation Cancelation { get; set; }
        [ForeignKey("Cancelation")]
        public int Cancelation_Id{ get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Phones> Phones { get; set; }
        public virtual ICollection<Photos> Photos { get; set; }
        public virtual ICollection<GuestReviewHotel> GuestReviewHotels { get; set; }



    }
}

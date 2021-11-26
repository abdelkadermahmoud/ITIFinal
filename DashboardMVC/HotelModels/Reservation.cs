using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public class Reservation :BaseModel
    {
      [Required]
      public DateTime CheckIn { get; set; }
      [Required]
      public DateTime CheckOut { get; set; }
      [Required]
      public DateTime TimeCreated { get; set; }
      public int  DiscountPercent { get; set; }
      public int NoOfAdults { get; set; }
      public int  NoOfChilds { get; set; }
      public Guest Guest { get; set; }
      [Required]
      [ForeignKey("Guest")]
      public int Guest_Id { get; set; }
      public virtual ICollection<Reserve_Room> Reserve_Room { get; set; }

    }
}

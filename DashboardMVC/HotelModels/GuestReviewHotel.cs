using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public enum Star
    {
        One=1,
        Two=2,
        Three=3,
        Four=4,
        Five=5
    }
    public class GuestReviewHotel:BaseModel
    {
      public Star stars { get; set; }
      public string Feedback { get; set; }
      public Guest Guest { get; set; }
      [ForeignKey("Guest")]
      public int Guest_Id { get; set; }
    public Hotel Hotel { get; set; }
    [ForeignKey("Hotel")]
    public int Hotel_Id { get; set; }
}
}

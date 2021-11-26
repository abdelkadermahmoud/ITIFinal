using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public class Reserve_Room :BaseModel
    {
        public Reservation Reservation { get; set; }
        [ForeignKey("Reservation")]
        public int Reservation_Id { get; set; }
        public Room Room { get; set; }
        [ForeignKey("Room")]
        public int Room_Id { get; set; }
    }
}

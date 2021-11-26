using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public class Room :BaseModel
    {
       [Required] 
     public string Description { get; set; }
    
     public Room_Type Room_Type { get; set; }
     [ForeignKey("Room_Type")]
     public int Room_Type_Id { get; set; }
     public Hotel Hotel { get; set; }
     [ForeignKey("Hotel")]
     public int Hotel_Id { get; set; }
     public virtual ICollection<Reserve_Room> Reserve_Room { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public class Room_Type :BaseModel
    {
       public string Type_Name { get; set; }
       public string Rate { get; set; }
       public string  View { get; set; }
       public virtual ICollection<Room> Room { get; set; }

    }
}

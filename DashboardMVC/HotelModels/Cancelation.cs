using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
   public class Cancelation :BaseModel
    {

        public string Description { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }

    }
}

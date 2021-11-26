using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
   public class Category :BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }

    }
}

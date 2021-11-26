using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
   public class City : BaseModel
    {
        public string Name { get; set; }
        public int Zip_code { get; set; }
        public Country Country { get; set; }
        [ForeignKey("Country")]
        public int Country_Id {get;set;}

        public virtual ICollection<Hotel> Hotels { get; set; }

    }
}

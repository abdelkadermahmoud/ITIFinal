using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public class Phones:BaseModel
    {
        public Hotel Hotel { get; set; }
        [ForeignKey("Hotel")]
        public int Hotel_Id { get; set; }
        public string PhoneNumber { get; set; }
    }
}

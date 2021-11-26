using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public class Country : BaseModel
    {
        public string Name { get; set; }

        public virtual ICollection<City> City { get; set; }

    }
}
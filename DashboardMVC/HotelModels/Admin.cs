using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
   public class Admin:BaseModel
    {
        public User User { get; set; }
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("User")]
        public new int ID { get; set; }
    }
}

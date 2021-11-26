using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public class PartnerInvoice :BaseModel
    {
        public int Inoice_Amount { get; set; }
       public DateTime TimePaid { get; set; }
       public DateTime TimeCanceled { get; set; }
        public int DepitAmount { get; set; }
        public int CreditAmount{ get; set; }
        public Partner Partner { get; set; }
        [ForeignKey("Partner")]
        public int Partner_Id { get; set; }
    }
}

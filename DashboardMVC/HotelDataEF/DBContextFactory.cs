using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDataEF
{
    public class DBContextFactory : IDBContextFactory
    {
        private readonly DbContext Context;
        public DBContextFactory()
        {
            Context =
                Context ?? new HotelContext();
        }
        public DbContext GetContext()
        {
            return Context;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ITS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ITSDbContext dbContext;

        public ITSDbContext Init()
        {
            return dbContext ?? (dbContext = new ITSDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}

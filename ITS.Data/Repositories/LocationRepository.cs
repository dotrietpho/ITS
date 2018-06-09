using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Repositories
{
    public interface ILocationRepository : IRepository<Location>
    {
   
    }
    public class LocationRepository : RepositoryBase<LocationRepository>
    { 
        public LocationRepository(IDbFactory dbFactory) : base(dbFactory)
        { }

       
    }
}

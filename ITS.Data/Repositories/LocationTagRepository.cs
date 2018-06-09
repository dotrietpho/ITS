using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Repositories
{
    public interface ILocationTagRepository : IRepository<LocationTag>
    { }
    public class LocationTagRepository : RepositoryBase<LocationTagRepository>
    {
        public LocationTagRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}

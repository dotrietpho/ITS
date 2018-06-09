using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Repositories
{
    public interface ILocationCategoryRepository : IRepository<LocationCategory>
    { }
    public class LocationCategoryRepository : RepositoryBase<LocationCategoryRepository>
    {
        public LocationCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}

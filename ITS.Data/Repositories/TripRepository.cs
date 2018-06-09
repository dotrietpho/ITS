using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Repositories
{
    public interface ITripRepository : IRepository<Trip>
    { }
    public class TripRepository : RepositoryBase<TripRepository>
    {
        public TripRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}

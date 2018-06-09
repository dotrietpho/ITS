using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Repositories
{
    public interface IStopPointRepository : IRepository<StopPoint>
    { }
    public class StopPointRepository : RepositoryBase<StopPointRepository>
    {
        public StopPointRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}

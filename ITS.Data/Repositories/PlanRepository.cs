using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Repositories
{
    public interface IPlanRepository : IRepository<Plan>
    { }
    public class PlanRepository : RepositoryBase<PlanRepository> /*, IPlanRepository*/
    {
        public PlanRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}

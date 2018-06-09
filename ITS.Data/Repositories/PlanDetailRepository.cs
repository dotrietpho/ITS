using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Repositories
{
    public interface IPlanDetailRepository : IRepository<PlanDetail>
    { }
    public class PlanDetailRepository : RepositoryBase<PlanDetailRepository>
    {
        public PlanDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}

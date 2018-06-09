using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Repositories
{
    public interface IVisitorStatisticRepository : IRepository<VisitorStatistic>
    { }
    public class VisitorStatisticRepository : RepositoryBase<VisitorStatisticRepository>
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}

using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Repositories
{
    public interface ICityCategoryRepository : IRepository<CityCategory>
    { }
    public class CityCategoryRepository : RepositoryBase<CityCategoryRepository>
    {
        public CityCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}

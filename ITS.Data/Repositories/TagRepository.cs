using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    { }
    public class TagRepository : RepositoryBase<TagRepository>
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}

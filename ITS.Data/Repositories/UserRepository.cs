using ITS.Data.Infrastructure;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ITS.Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    { }
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}

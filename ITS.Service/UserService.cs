using ITS.Data.Infrastructure;
using ITS.Data.Repositories;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Service
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(string id);
      
        IEnumerable<User> GetAll();
        User GetById(string id);
        void SaveChanges();
    }
    class UserService : IUserService
    {
        IUserRepository _userRepository;
        IUnitOfWork _unitOfWork;
        public UserService(IUserRepository userrepository, IUnitOfWork unitofwork)
        {
            this._userRepository = userrepository;
            this._unitOfWork = unitofwork;
        }
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<User> GetAll()
        {
            var query = _userRepository.GetAll();
            return query;
        }

        public User GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}

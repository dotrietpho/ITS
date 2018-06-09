using ITS.Data.Infrastructure;
using ITS.Data.Repositories;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        IEnumerable<User> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<User> GetAllByTagPaging(int page, int pageSize, out int totalRow);
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
            _userRepository.Add(user);
        }

        public void Delete(string id)
        {
            _userRepository.Delete(id);
        }


        public IEnumerable<User> GetAll()
        {
            var query = _userRepository.GetAll();
            return query;
        }

        public IEnumerable<User> GetAllByTagPaging(int page, int pageSize, out int totalRow)
        {
            return _userRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<User> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _userRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public User GetById(string id)
        {
            return _userRepository.GetSingleByID(id);
        }

        

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }
    }
}

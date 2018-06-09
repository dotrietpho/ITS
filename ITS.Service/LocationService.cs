using ITS.Data.Infrastructure;
using ITS.Data.Repositories;
using ITS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ITS.Data;

namespace ITS.Service
{
    public interface ILocationService 
    {
        void Add(Location user);
        void Update(Location user);
        void Delete(int id);

        IEnumerable<Location> GetAll();
        Location GetById(int id);
        void SaveChanges();
        IEnumerable<Location> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Location> GetAllByTagPaging(IEnumerable<Tag> tags);
    }
    public class LocationService : ILocationService
    {
        ILocationRepository _locationRepository;
        IUnitOfWork _unitOfWork;
        public LocationService(ILocationRepository locationRepository, IUnitOfWork unitofwork)
        {
            this._locationRepository = locationRepository;
            this._unitOfWork = unitofwork;
        }
        public void Add(Location location)
        {
            _locationRepository.Add(location);
        }

        public void Delete(int id)
        {
            _locationRepository.Delete(id);
        }


        public IEnumerable<Location> GetAll()
        {
            var query = _locationRepository.GetAll();
            return query;
        }

        public IEnumerable<Location> GetAllByTagPaging(IEnumerable<Tag> tags)
        {
            using (var db = new ITSDbContext())
            {
                var query = from p in db.Locations
                            join q in db.LocationTags
                            on p.ID equals q.LocationID
                            where q.TagID == tags.First().ID
                            select p;

                foreach (Tag tag in tags)
                {
                    query = from p in query
                            join q in db.LocationTags
                            on p.ID equals q.LocationID
                            where q.TagID == tag.ID
                            select p;
                }
                return query;
            }
            
        }

        public IEnumerable<Location> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _locationRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Location GetById(int id)
        {
            return _locationRepository.GetSingleByID(id);
        }



        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Location location)
        {
            _locationRepository.Update(location);
        }
    }
}

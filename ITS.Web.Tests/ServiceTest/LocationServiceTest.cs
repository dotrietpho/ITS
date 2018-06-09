using ITS.Data.Infrastructure;
using ITS.Data.Repositories;
using ITS.Model.Models;
using ITS.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Web.Tests.ServiceTest
{
    [TestClass]
    public class LocationServiceTest
    {
        private Mock<ILocationRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private LocationService _locationService;
        private List<Location> listLocation;
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<ILocationRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _locationService = new LocationService(_mockRepository.Object, _mockUnitOfWork.Object);
            listLocation = new List<Location>()
            {
                new Location() {ID = 1, Name="NH1",Contact="0254123561",Address="something",Status=true },
                new Location() {ID = 2, Name="NH1",Contact="0254123561",Address="something",Status=true },
                new Location() { ID = 3, Name = "NH1", Contact = "0254123561", Address = "something", Status = true },
                new Location() { ID = 4, Name = "NH1", Contact = "0254123561", Address = "something", Status = true },
                new Location() { ID = 5, Name = "NH1", Contact = "0254123561", Address = "something", Status = true },
            };
            }
    

        [TestMethod]
        public void Location_Service_GetAll()
        {
            //setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(listLocation);

            //call action
            var resualt = _locationService.GetAll() as List<Location>;

            //compare
            Assert.IsNotNull(resualt);
            Assert.AreEqual(5, resualt.Count);
        }

        [TestMethod]
        public void Location_Service_GetByMultiTab()
        { }

        [TestMethod]
        public void Location_Service_Create()
        { }
    }
}

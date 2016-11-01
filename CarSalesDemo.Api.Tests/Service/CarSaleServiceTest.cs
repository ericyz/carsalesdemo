using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSalesDemo.Api.Service.Interface;
using CarSalesDemo.Model;
using CarSalesDemo.Repository.Interface;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;

namespace CarSalesDemo.Api.Tests.Service {
    [TestFixture]
    public sealed class CarSaleServiceTest {

        #region sample data
        private Car car1 = new Car() { Id = 1, ImageName = "image1", Price = 0, SellerType = SellerType.DEALER, Title = "title1" };
        private Car car2 = new Car() { Id = 2, ImageName = "image2", Price = 1, SellerType = SellerType.PRIVATE, Title = "title2" };
        private Car car3 = new Car() { Id = 3, ImageName = "image3", Price = 2, SellerType = SellerType.DEALER, Title = "title3" };
        private Car car4 = new Car() { Id = 4, ImageName = "image4", Price = 3, SellerType = SellerType.PRIVATE, Title = "title4" };
        private Car car5 = new Car() { Id = 5, ImageName = "image5", Price = 4, SellerType = SellerType.DEALER, Title = "title5" };
        private IList<Car> sampleData;
    #endregion
        private ICarSaleService _service;
        [SetUp]
        public void SetUp() {

            sampleData = new List<Car>
                          {
                                car1, car2, car3, car4, car5
                             };

            Mock<IRepository<Car>> carRepositoryMock = new Mock<IRepository<Car>>();
            carRepositoryMock.Setup(s => s.ReadAll()).Returns(sampleData);
            carRepositoryMock.Setup(s => s.Read(1)).Returns(car1);
            carRepositoryMock.Setup(s => s.Read(2)).Returns(car2);
            carRepositoryMock.Setup(s => s.Read(3)).Returns(car3);
            carRepositoryMock.Setup(s => s.Read(4)).Returns(car4);
            carRepositoryMock.Setup(s => s.Read(5)).Returns(car5);
           _service = new CarSaleService(carRepositoryMock.Object);
        }
        [Test]
        public void ReadAll_Test_Count_ShouldPass() {
            var records = _service.GetCars();
            Assert.AreEqual(5, records.Count());
        }
        [Test]
        public void ReadType_ByDealer_Test_Count() {
            var records = _service.GetCarByResellerType((int)SellerType.DEALER);
            Assert.AreEqual(3, records.Count());
        }

        [Test]
        public void ReadType_ByPrivate_Test_Count() {
            var records = _service.GetCarByResellerType((int)SellerType.PRIVATE);
            Assert.AreEqual(2, records.Count());
        }

        [Test]
        public void ReadById_Test_UpperCase_ShouldReturnCorrectData() {

            var record = _service.GetCarById(1);
            Assert.AreEqual(car1.Id, record.Id);
            Assert.AreEqual(car1.ImageName, record.ImageName);
            Assert.AreEqual(car1.Price, record.Price);
            Assert.AreEqual(car1.SellerType, record.SellerType);
            Assert.AreEqual(car1.Title, record.Title);
        }


    }
}

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

        private ICarSaleService _service;
        [SetUp]
        public void SetUp() {
            _service = new CarSaleService();
        }
        [Test]
        public void ReadAll_Test_Count_Shouldbe11() {
            var records = _service.GetCars();
            Assert.AreEqual(11, records.Count());
        }
        [Test]
        public void ReadType_BySeller_Lowercase_Test_Count_Shouldbe6() {
            var records = _service.GetCarByResellerType(0);
            Assert.AreEqual(6, records.Count());
        }

        [Test]
        public void ReadType_BySeller_UpperCase_Test_Count_Shouldbe6() {
            var records = _service.GetCarByResellerType(0);
            Assert.AreEqual(6, records.Count());
        }
        [Test]
        public void ReadType_ByPrivate_Test_Lowercase_Count_Shouldbe5() {
            var records = _service.GetCarByResellerType(1);
            Assert.AreEqual(5, records.Count());
        }
        [Test]
        public void ReadType_ByPrivate_Test_UpperCase_Count_Shouldbe5() {
            var records = _service.GetCarByResellerType(1);
            Assert.AreEqual(5, records.Count());
        }
        [Test]
        public void ReadType_ByPrivate_Test_UpperCase_ShouldReturnCorrectData() {
            var expectedJson = @"  {""Id"": 1,
    ""Title"": ""2016 Subaru Forester 2.5i-L S4 Auto AWD MY16"",
    ""SellerType"": 0,
    ""ImageName"": ""car1.jpg"",
    ""Price"": 33950.0,
    ""LastModifiedDate"": ""05/11/2016""} ";
            var expectedCar = JsonConvert.DeserializeObject<Car>(expectedJson);
            var record = _service.GetCarById(1);
            Assert.AreEqual(expectedCar.Id, record.Id);
            Assert.AreEqual(expectedCar.ImageName, record.ImageName);
            Assert.AreEqual(expectedCar.Price, record.Price);
            Assert.AreEqual(expectedCar.SellerType, record.SellerType);
            Assert.AreEqual(expectedCar.Title, record.Title);
        }


    }
}

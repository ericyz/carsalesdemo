using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSalesDemo.Api.Service.Interface;
using CarSalesDemo.Model;
using CarSalesDemo.Repository.Interface;
using Moq;
using NUnit.Framework;

namespace CarSalesDemo.Api.Tests.Service {
    [TestFixture]
    public sealed class CarSaleServiceTest
    {

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
            var records = _service.GetCarByResellerType("dealer");
            Assert.AreEqual(6, records.Count());
        }

        [Test]
        public void ReadType_BySeller_UpperCase_Test_Count_Shouldbe6() {
            var records = _service.GetCarByResellerType("dealer");
            Assert.AreEqual(6, records.Count());
        }
        [Test]
        public void ReadType_ByPrivate_Test_Lowercase_Count_Shouldbe5() {
            var records = _service.GetCarByResellerType("private");
            Assert.AreEqual(5, records.Count());
        }
        [Test]
        public void ReadType_ByPrivate_Test_UpperCase_Count_Shouldbe5() {
            var records = _service.GetCarByResellerType("private");
            Assert.AreEqual(5, records.Count());
        }


    }
}

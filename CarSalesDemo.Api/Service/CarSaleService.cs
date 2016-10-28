using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using CarSalesDemo.Model;
using CarSalesDemo.Repository;
using CarSalesDemo.Repository.Interface;

namespace CarSalesDemo.Api.Service.Interface {

    public class CarSaleService : ICarSaleService {
        static readonly string _provider = ConfigurationManager.AppSettings["DataProvier"];
        static readonly IRepositoryFactory _factory = RepositoryFactories.GetRepositoryFactory(_provider);
        static readonly IRepository<Car> _carRepository = _factory.CarRepository;

        public IEnumerable<Car> GetCars() {
            return _carRepository.ReadAll();
        }

        public IEnumerable<Car> GetCarByResellerType(SellerType type) {
            return GetCarByResellerType(type.ToString());
        }

        public IEnumerable<Car> GetCarByResellerType(string type) {
            return _carRepository.ReadAll().Where(s => s.SellerType.ToString().ToUpper() == type.ToUpper());
        }
    }
}
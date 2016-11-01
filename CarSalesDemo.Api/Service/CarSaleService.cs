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
        //        static readonly string _provider = ConfigurationManager.AppSettings["DataProvier"];
        //        static readonly IRepositoryFactory _factory = RepositoryFactories.GetRepositoryFactory(_provider);
        //        static readonly IRepository<Car> _carRepository = _factory.CarRepository;

        private readonly IRepository<Car> _carRepository;

        public CarSaleService(IRepository<Car> carRepository) {
            this._carRepository = carRepository;
        }
        public IEnumerable<Car> GetCars() {
            return _carRepository.ReadAll();
        }

        public IEnumerable<Car> GetCarByResellerType(int type) {
            return _carRepository.ReadAll().Where(s => (int)s.SellerType == type);
        }

        public Car GetCarById(int id) {
            return _carRepository.ReadAll().FirstOrDefault(s => s.Id == id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarSalesDemo.Model;

namespace CarSalesDemo.Api.Service.Interface {
    public interface ICarSaleService {
        IEnumerable<Car> GetCars();
        IEnumerable<Car> GetCarByResellerType(SellerType type);
        IEnumerable<Car> GetCarByResellerType(string type);
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CarSalesDemo.Model;
using CarSalesDemo.Repository.Base;
using CarSalesDemo.Repository.CustomException;
using CarSalesDemo.Repository.Interface;
using Newtonsoft.Json;

namespace CarSalesDemo.Repository {
    public class CarRepository : JsonRepositoryBase, IRepository<Car> {
        public CarRepository(string jsonSrc) : base(jsonSrc) {
        }

        public IEnumerable<Car> ReadAll() {
            string carJson = File.ReadAllText(this._jsonSrc);
            return JsonConvert.DeserializeObject<IEnumerable<Car>>(carJson);
        }

        public Car Read(int id) {
            try {
                return ReadAll().First(s => s.Id == id);
            } catch (Exception) {
                throw new IdNotFoundException($"Car Id {id} does not exist in the datasource.");
            }
        }

        public void Update(int id, Car car) {
            throw new NotImplementedException();
        }

        public void Insert(Car car) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSalesDemo.Repository.Base;
using CarSalesDemo.Repository.Interface;

namespace CarSalesDemo.Repository {
    public class JsonDataService : IJsonDataService
    {

        private readonly string _jsonFolder;
        public JsonDataService(string jsonFolder)
        {
            _jsonFolder = jsonFolder;
        }

        public T GetRepository<T>( string type) where T : JsonRepositoryBase {
            var ret = (T)Activator.CreateInstance(typeof(T), $"{this._jsonFolder}{type}.json");
            return ret;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSalesDemo.Repository.Base;

namespace CarSalesDemo.Repository.Interface {
  public  interface IJsonDataService
  {
      T GetRepository<T>(string jsonFileName) where T : JsonRepositoryBase;
  }
}

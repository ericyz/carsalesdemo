using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesDemo.Repository.Interface {
    public class JsonRepository : IRepositoryFactory {
        public CarRepository CarRepository { get; } = new CarRepository("cars");
    }
}

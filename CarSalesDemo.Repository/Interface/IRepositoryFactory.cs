using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesDemo.Repository {
    public interface IRepositoryFactory
    {
         CarRepository CarRepository { get; }
    }
}

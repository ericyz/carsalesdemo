using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSalesDemo.Model.Interface;

namespace CarSalesDemo.Model
{
    public class Car : IEntity{
        public string Title { get; set; }
        public SellerType SellerType { get; set; }
        public string ImageName { get; set; }
        public decimal Price { get; set; }

        public int Id { get; set; }
    }

    public enum SellerType {
        DEALER, PRIVATE
    }
}

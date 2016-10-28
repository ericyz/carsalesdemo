using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesDemo.Repository.CustomException {
  public  class IdNotFoundException :Exception{
        public IdNotFoundException()
             : base() { }

        public IdNotFoundException(string message)
             : base(message) { }

        public IdNotFoundException(string message, Exception inner) : base(message, inner) { }

        public IdNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

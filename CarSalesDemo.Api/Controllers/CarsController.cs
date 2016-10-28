using CarSalesDemo.Api.Service.Interface;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace CarSalesDemo.Api.Controllers {
    public class CarsController : ApiController {

        private readonly ICarSaleService _service;
        public CarsController() : this(new CarSaleService()) { }

        public CarsController(ICarSaleService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get() {
            try {
                var cars = await Task.FromResult(_service.GetCars());
                return Ok(cars);
            } catch (Exception) {
                return InternalServerError();
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get(string type) {
            try {
                if (string.IsNullOrEmpty(type))
                    return BadRequest();
                var car = await Task.FromResult(_service.GetCarByResellerType(type));
                return Ok(car);
            } catch (Exception) {
                return InternalServerError();
            }
        }
    }
}
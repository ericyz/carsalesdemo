using CarSalesDemo.Api.Service.Interface;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CarSalesDemo.Api.Controllers {
    [EnableCors(origins: "http://localhost:49603", headers: "*", methods: "*")]
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
                var car = await Task.FromResult(_service.GetCarByResellerType(int.Parse(type)));
                return Ok(car);
            } catch (Exception) {
                return InternalServerError();
            }
        }

        [HttpGet]
        [Route("api/cars/{id}")]
        public async Task<IHttpActionResult> GetById(int id) {
            try {
                var car = await Task.FromResult(_service.GetCarById(id));
                if (car == null)
                    return NotFound();
                return Ok(car);
            } catch (Exception) {
                return InternalServerError();
            }
        }
    }
}
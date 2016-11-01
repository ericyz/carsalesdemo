using CarSalesDemo.Api.Service.Interface;
using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Http.Cors;
using CarSalesDemo.Api.Attributes;
using CarSalesDemo.Api.Controllers.Base;
using CarSalesDemo.Repository;
using CarSalesDemo.Repository.Interface;

namespace CarSalesDemo.Api.Controllers {
    [CarSalesCorPolicy]
    public class CarsController : DatabaseController {

        private readonly ICarSaleService _service;

        public CarsController(): this(new JsonDataService(HostingEnvironment.MapPath($"{ConfigurationManager.AppSettings["DataFolder"]}Json/")))
        {
        }

        public CarsController(IJsonDataService service = null)
        {
            var dataProvider = ConfigurationManager.AppSettings["DataProvier"];
            if (dataProvider.ToUpper() == DataProvier.JSON.ToString())
            {
                var carRepository = RepositoryFactories.GetRepositoryFactory(dataProvider, service).CarRepository;
                _service = new CarSaleService(carRepository);
            } else
            {
                throw new Exception($"The data provide {dataProvider} has not been implemented");
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get() {
            try {
                var cars = await Task.FromResult(_service.GetCars());
                return Ok(cars);
            } catch (Exception ex) {
                Debug.WriteLine(ex.ToString());
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
            } catch (Exception ex) {
                Debug.WriteLine(ex.ToString());
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
            } catch (Exception ex) {
                Debug.WriteLine(ex.ToString());
                return InternalServerError();
            }
        }
    }
}
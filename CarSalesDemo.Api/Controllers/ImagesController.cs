using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Http.Cors;
using CarSalesDemo.Api.HttpResult;
using CarSalesDemo.Api.Service;
using CarSalesDemo.Api.Service.Interface;

namespace CarSalesDemo.Api.Controllers {
    [EnableCors(origins: "http://localhost:49603", headers: "*", methods: "*")]
    public class ImagesController : ApiController {
        private IImageService _imageService;
        public ImagesController(IImageService service) {
            _imageService = service;
        }

        public ImagesController() : this(new ImageService(HostingEnvironment.MapPath($"{ConfigurationManager.AppSettings["DataFolder"]}Image/"))) {

        }

        [HttpGet]
        [Route("api/images")]
        public async Task<IHttpActionResult> Get(string name)
        {
            try
            {
                StreamContent content = await Task.FromResult(_imageService.LoadImage(name));
                return new ImageResult(content);
            } catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return InternalServerError();
            } 
        }

//        [HttpGet]
//        [Route("api/image/compress")]
//        public async Task<IHttpActionResult> GetCompressed(string name) {
//            StreamContent content = null;
//            try {
//                 content = _imageService.LoadCompressImage(name);
//                    return new ImageResult(content); ;
//            } catch (Exception ex) {
//                Debug.WriteLine(ex.ToString());
//                return InternalServerError();
//            } finally {
//                if (content != null) {
//                    content.Dispose();
//                }
//            }
//        }
    }
}

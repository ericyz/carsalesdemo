using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace CarSalesDemo.Api.HttpResult {
    public class ImageResult : IHttpActionResult
    {

        private StreamContent _content;

        public ImageResult(StreamContent content)
        {
            _content = content;
        }
        Task<HttpResponseMessage> IHttpActionResult.ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage();
                response.Content = _content;
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");
                return  Task.FromResult(response);
           
        }
    }
}
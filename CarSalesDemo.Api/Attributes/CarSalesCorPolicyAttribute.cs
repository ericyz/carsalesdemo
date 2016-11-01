using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace CarSalesDemo.Api.Attributes {
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class CarSalesCorPolicyAttribute : Attribute,ICorsPolicyProvider {

        private CorsPolicy _policy;
        public CarSalesCorPolicyAttribute()
        {
            // Create a CORS policy.
            _policy = new CorsPolicy {
                AllowAnyMethod = true,
                AllowAnyHeader = true
            };

            // Add allowed origins.
            _policy.Origins.Add("http://carsalesdomo.azurewebsites.net");
            _policy.Origins.Add("http://localhost:63024");
        }
        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken) {
            return Task.FromResult(_policy);
        }
    }
}
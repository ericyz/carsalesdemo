using System.IO;
using System.Net.Http;

namespace CarSalesDemo.Api.Service.Interface {
    public interface IImageService {
        byte[] LoadImage(string fileName);
    }
}
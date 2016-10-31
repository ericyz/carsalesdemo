using System.Net.Http;

namespace CarSalesDemo.Api.Service.Interface {
    public interface IImageService {
        StreamContent LoadImage(string fileName);
        StreamContent LoadCompressImage(string fileName);
    }
}
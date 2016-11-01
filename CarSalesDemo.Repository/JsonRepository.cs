using CarSalesDemo.Repository.Interface;

namespace CarSalesDemo.Repository {
    public class JsonRepository : IRepositoryFactory {

        public CarRepository CarRepository { get; }

        public JsonRepository(IJsonDataService jsonService)
        {
            CarRepository = jsonService.GetRepository<CarRepository>("cars");
        }
    }
}

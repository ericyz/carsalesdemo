using System;
using CarSalesDemo.Repository.Interface;

namespace CarSalesDemo.Repository {
    public class RepositoryFactories {

        public static IRepositoryFactory GetRepositoryFactory(string repositoryType) {
            return GetRepositoryFactory(repositoryType);
        }

        public static IRepositoryFactory GetRepositoryFactory(string repositoryType, IJsonDataService dataService = null) {

            if (repositoryType.ToUpper() == "JSON" && dataService == null)
                throw new Exception("Json repository requires a json data service.");

            switch (repositoryType.ToUpper()) {
                case "JSON":
                    return new JsonRepository(dataService);
                case "SQLSever":
                    throw new NotImplementedException("SQL Server data access layer has not been implemented.");
                default:
                    throw new Exception("Not Possible. Please check Data Provider");
            }
        }
    }

    public enum DataProvier {
        JSON,
        SQLSever
    }
}

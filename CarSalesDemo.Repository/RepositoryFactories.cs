using System;
using CarSalesDemo.Repository.Interface;

namespace CarSalesDemo.Repository {
    public class RepositoryFactories {

        public static IRepositoryFactory GetRepositoryFactory(DataProvier repositoryType) {
            return GetRepositoryFactory(repositoryType.ToString());
        }

        public static IRepositoryFactory GetRepositoryFactory(string repositoryType) {

            if (repositoryType == DataProvier.JSON.ToString()) {
                return new JsonRepository();

            } else if (repositoryType == DataProvier.SQLSever.ToString()) {
                throw new NotImplementedException("SQL Server data access layer has not been implemented.");

            } else {
                return new JsonRepository();

            }
        }
    }

    public enum DataProvier {
        JSON,
        SQLSever
    }
}

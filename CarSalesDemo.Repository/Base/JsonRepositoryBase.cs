using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using CarSalesDemo.Repository.Utility;

namespace CarSalesDemo.Repository.Base {
    public abstract class JsonRepositoryBase {
        protected string _jsonSrc;

        protected JsonRepositoryBase(string filePath)
        {
            _jsonSrc = filePath;
//                ConfigurationManager.AppSettings["DataFolder"] + "Json/";
//            _jsonSrc = HostingEnvironment.MapPath($"{jsonFolderPath}${jsonFileName}.json");
        }
    }
}

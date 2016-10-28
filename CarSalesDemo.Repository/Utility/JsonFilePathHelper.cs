using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;

namespace CarSalesDemo.Repository.Utility {
    public static class JsonFilePathHelper {
        /// <summary>
        /// Get the json file path with absolute or relative path
        /// </summary>
        /// <param name="folderPath">path of the json folder</param>
        /// <param name="fileName">file name</param>
        /// <returns>Path of the json file</returns>
        public static string GetJsonFilePath(string folderPath, string fileName)
        {
            return folderPath.StartsWith("~")
                       ? HostingEnvironment.MapPath($"{folderPath}{fileName}") : $"{folderPath}{fileName}";
        }

    }
}

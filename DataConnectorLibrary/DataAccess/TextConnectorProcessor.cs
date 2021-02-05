using DataConnectorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnectorLibrary.DataAccess
{
   static class TextConnectorProcessor
    {
        public static string FullFilePath(this string name)
        {
            return ConfigurationManager.AppSettings["filePath"] + "/" + name;
        }

        public static List<UserModel> ConvertToUserModel(this List<string> lines)
        {
            List<UserModel> output = new List<UserModel>();

          
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                UserModel model = new UserModel();
                model.Username = cols[0];
                model.Password = cols[1];
                model.Email = cols[3];
                output.Add(model);
            }
            return output;
        }

        public static List<string> LoadFile(this string file)
        {
            
        }
    }
}

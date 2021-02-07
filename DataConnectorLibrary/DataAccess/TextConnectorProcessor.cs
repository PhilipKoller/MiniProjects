using DataConnectorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;


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
                model.Id = Int32.Parse(cols[0]);
                model.Username = cols[1];
                model.Password = cols[2];
                model.Email = cols[3];
                output.Add(model);
            }
            return output;
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static void SaveToUserFile(this List<UserModel> users, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (UserModel p in users)
            {
                lines.Add($"{p.Id},{p.Username},{p.Password},{p.Email}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
           
        }
    }
}

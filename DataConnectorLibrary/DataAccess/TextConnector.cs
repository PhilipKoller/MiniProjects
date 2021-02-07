using System;
using System.Collections.Generic;
using System.Linq;
using DataConnectorLibrary.Models;

namespace DataConnectorLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        const string userFile = "UserAccount.csv";

        public UserModel AddUser(UserModel model)
        {
            // Load the text file and convert the text to List<UserModel>
            List<UserModel> users = userFile.FullFilePath().LoadFile().ConvertToUserModel();

            // Find the max ID and Add 1
            int currentId = 1;
            if (users.Count > 0)
            {
                currentId = users.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add new record with the ID
            users.Add(model);

            // Save new record to file 
            users.SaveToUserFile(userFile);

            return model;
          

        }

    }
}

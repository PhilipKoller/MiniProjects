using System;
using System.Collections.Generic;
using DataConnectorLibrary;
using DataConnectorLibrary.DataAccess;
using DataConnectorLibrary.Models;

namespace DataConnectorLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        const string userFile = "UserAccount.csv";

        public UserModel AddUser(UserModel userModel)
        {
            throw new NotImplementedException();
        }

    }
}

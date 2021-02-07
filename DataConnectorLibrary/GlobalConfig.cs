using DataConnectorLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnectorLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get;  private set; }

    
    public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.TextFile:
                    TextConnector text = new TextConnector();
                    Connections = text;
                    break;
                case DatabaseType.Sql:
                    break;
                default:
                    break;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

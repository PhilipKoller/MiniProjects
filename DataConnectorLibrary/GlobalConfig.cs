using DataConnectorLibrary.DataAccess;
using System;
using System.Collections.Generic;
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
            if (true)
            {
                // if text file is true then Instatiate textfileconnector class 
            }

            if (true)
            {
                // if sql is true then Instatiate sqlconnector class
            }

        }
    }
}

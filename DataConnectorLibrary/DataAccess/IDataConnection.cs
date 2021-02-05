using DataConnectorLibrary.Models;

namespace DataConnectorLibrary.DataAccess
{
   public interface IDataConnection
    {
       UserModel AddUser(UserModel userModel);
    }
}

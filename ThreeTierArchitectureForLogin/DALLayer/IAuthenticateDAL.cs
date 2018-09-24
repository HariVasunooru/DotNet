using BusinessModels;
using System.Collections.Generic;
namespace DALLayer
{
    public interface IAuthenticateDAL
    {
     List<User> DALGetUserDetails(int userId,string password);

    }
}
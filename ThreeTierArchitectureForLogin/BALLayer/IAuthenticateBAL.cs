using BusinessModels;
using System.Collections.Generic;
namespace BALLayer
{
    public interface IAuthenticateBAL
    {
         List<User> BALGetUserDetails(int userId,string password);
         
    }
}
using System;
using System.Collections.Generic;
using BusinessModels;
namespace DALLayer
{
    public class DALAuthenticate : IAuthenticateDAL
    {
        
        List<User> userList = new List<User>(){
            new User(){Id=2183,Name="Hari",Password="2183"},
            new User(){Id=1510,Name="Kumar",Password="1510"},
            new User(){Id=1000,Name="Vasunoori",Password="1000"}
        };


        public List<User> DALGetUserDetails(int userId, string password)
        {
            List<User> returnList = new List<User>();
            foreach (var item in userList)
            {
                if (item.Id == userId & item.Password == password)
                {
                    System.Console.WriteLine("Login Sucessfull");
                    returnList.Add(item);

                }
            }
            return returnList;

        }


    }
}

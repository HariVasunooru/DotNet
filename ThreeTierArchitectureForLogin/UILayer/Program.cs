using System;
using BALLayer;
using System.Collections.Generic;
using BusinessModels;
namespace UILayer
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuthenticateBAL BALObj = BALFactory.GetBALObject();
            
            //Passing UserId & Password
            List<User> uiList = BALObj.BALGetUserDetails(2183, "2183");
            foreach (var item in uiList)
            {
                System.Console.WriteLine("Login Sucessfull");
                System.Console.WriteLine($"Id:{item.Id}\tName{item.Name}");

            }

            Console.ReadKey();

        }
    }
}

using System;
using DALLayer;
using BusinessModels;
using System.Collections.Generic;
namespace BALLayer
{
    public class BALAuthenticate : IAuthenticateBAL
    {
        DALAuthenticate _DALObj;
        public BALAuthenticate()
        {
            _DALObj = new DALAuthenticate();
        }
        public List<User> BALGetUserDetails(int id, string password)
        {
            return _DALObj.DALGetUserDetails(id, password);
        }
    }

}

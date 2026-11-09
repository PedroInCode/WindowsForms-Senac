using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWindowsForms.Class
{
    internal class Login
    {
        private int _id;
        private string _userLogin;
        private string _userPassword;
        private string _userProfile;

        public Login(int id, string userLogin, string userPassword, string userProfile)
        {
            _id = id;
            _userLogin = userLogin;
            _userPassword = userPassword;
            _userProfile = userProfile;
        }

        public bool Authenticate(string username, string password)
        {
            return username == this._userLogin && password == this._userPassword;
        }
    }
}

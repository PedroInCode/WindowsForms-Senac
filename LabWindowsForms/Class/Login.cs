using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWindowsForms.Class
{
    public class Login
    {
        private int _id;
        private string _username;
        private string _userLogin;
        private string _userPassword;
        private string _userProfile;
        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string UserLogin { get => _userLogin; set => _userLogin = value; }
        public string UserPassword { get => _userPassword; set => _userPassword = value; }
        public string UserProfile { get => _userProfile; set => _userProfile = value; }

        public Login(int id, string username, string userLogin, string userPassword, string userProfile)
        {
            _id = id;
            _username = username;
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

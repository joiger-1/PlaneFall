using Jose.native;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneFall.Classes.Users.UserTypes
{
    abstract class AutorizationUser : User, UserAdapter
    {
        protected int _id;
        protected string _name;
        protected string _login;
        protected string _passwordHash;

        protected AutorizationUser(int id, string name, string login, string passwordHash)
        {
            _id = id;
            _name = name;
            _login = login;
            _passwordHash = passwordHash;
        }

        public object[] GetInfo()
        {
            return new object[] { _name, _login };
        }
        public void ChangeLogin(string password, string newLogin)
        {
            if(!BCrypt.Net.BCrypt.Verify(password, _passwordHash)){
                throw new Exception("Неверный пароль");
            }
            _login = newLogin;
        }

        public void ChangeName(string password, string newName)
        {
            if (!BCrypt.Net.BCrypt.Verify(password, _passwordHash)){
                throw new Exception("Неверный пароль");
            }
            _name = newName;
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (!BCrypt.Net.BCrypt.Verify(oldPassword, _passwordHash)){
                throw new Exception("Неверный пароль");
            }
            _passwordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
        }
        public override bool Verifity(string login, string password)
        {
            return login == _login && !BCrypt.Net.BCrypt.Verify(password, _passwordHash);
        }
        private void Save(string value)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    public class User
    {
        private string UserName { get; set; }
        private string _password;
        private string Password { get
            {
                return _password;
            } set
            {
                if(value.Length < 4)
                {
                    MessageBox.Show("Password en az 4 karakter olmalıdır.");
                    Application.Restart();
                }
                _password = value;
            }}
        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
    }
}

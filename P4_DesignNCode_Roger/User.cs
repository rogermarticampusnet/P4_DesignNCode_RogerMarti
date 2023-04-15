using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DesignNCode_Roger
{
    public abstract class User
    {
        public int id;
        public string name;
        public string surname;
        public string email;
        private string password;
        private int telephone;
        private string address;
        private string DNI;
    }
}

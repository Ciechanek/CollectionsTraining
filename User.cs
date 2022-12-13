using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTests
{
    public class User
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        public User(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
        }
        public string GetFirstNameOfUser()
        {
            return _firstName;
        }
        public string GetLastNameOfUser()
        {
            return _lastName;
        }
    }
}

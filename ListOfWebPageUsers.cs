using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTests
{
    public class ListOfWebPageUsers
    {
        public List<User> usersList = new List<User>();
        private User user;

        public User CreateNewUser(string firstName, string lastName)
        {
            user = new User(firstName, lastName);
            return user;
        }
        public void AddUserToList(User user)
        {
            usersList.Add(user);
        }
        public void WriteListInAlphabeticalOrder(List<User> users)
        {
            List<User> sortedList = users.OrderBy(x => x.GetLastNameOfUser()).ToList();
            foreach (User user in sortedList)
            {
                Console.WriteLine(user.GetLastNameOfUser());
            }
        }
        public void CopyListToAnotherOne(List<User> list)
        {

        }
    }
}
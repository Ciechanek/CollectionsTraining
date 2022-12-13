using System;

namespace CollectionTests
{
    class Program
    {
        public static void Main(string[] args)
        {
            ListOfWebPageUsers listOfWebPageUsers = new ListOfWebPageUsers();
            for (int i=0; i<10; i++)
            {
                User user = listOfWebPageUsers.CreateNewUser(RandomStringGenerator.RandomString(5), RandomStringGenerator.RandomString(5));
                listOfWebPageUsers.AddUserToList(user);
            }

            for (int i = 0; i < listOfWebPageUsers.usersList.Count; i++)
            {
                Console.WriteLine("FirstName: " + listOfWebPageUsers.usersList[i].GetFirstNameOfUser() +
                    " LastName: " + listOfWebPageUsers.usersList[i].GetLastNameOfUser());
            }

            listOfWebPageUsers.WriteListInAlphabeticalOrder(listOfWebPageUsers.usersList);
        }
    }
}

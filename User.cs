using System;

namespace Casino
{
    class User{
        public string Username { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public int age { get; set; }
        public string BankId { get; set; }


        public LoginUser(string Username, string Password){
            if(Username == currentUsename && Password == currentPassword){
                return System.Console.WriteLine("You are logged in");
            }
        }

        public LoginBankId(){
            return false;
        }
    }
}



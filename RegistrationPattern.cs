using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class RegistrationPattern
    {
        public static string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string email = "^[a-z]{3,}([.]{1}[a-z]{2,})?[/@/][a-z]{2,5}[/./][a-z]{2,5}([.]{1}[a-z]{2})?$";
        public static string mobileNo = "^91[/ /][6-9]{1}[0-9]{9}$";
        public static string password = "^(?=.*[!@#$%^&*]{1})(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9@$!%*#?&]{8,}$";
        public static string UC9 = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";
        public void Validate(string data)
        {
            string result = Regex.IsMatch(data, UC9) ? $"{data}: valid" : $"{data}: invalid";

            Console.WriteLine(result);
        }
    }
}
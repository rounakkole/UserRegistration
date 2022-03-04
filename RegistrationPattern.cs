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

        public void Validate(string data)
        {
          
                string result = Regex.IsMatch(data, lastName) ? $"{data}: valid" : $"{data}: invalid";

                Console.WriteLine(result);
            

        }
    }
}
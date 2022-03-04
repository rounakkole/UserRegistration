// See https://aka.ms/new-console-template for more information
using System;

namespace UserRegistration
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("user registration");
            RegistrationPattern registrationPattern = new RegistrationPattern();
            registrationPattern.Validate("abcd1234");
            registrationPattern.Validate("abcdefhi");
            registrationPattern.Validate("abcDE1234");
            registrationPattern.Validate("abcDE12");
        }
    }
}

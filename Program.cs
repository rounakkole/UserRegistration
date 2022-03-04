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
            registrationPattern.Validate("91 9876543210");
            registrationPattern.Validate("919876543210");
            registrationPattern.Validate("91 5632147890");
            registrationPattern.Validate("91 987654321");
        }
    }
}

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
            registrationPattern.Validate("Rahul");
            registrationPattern.Validate("Raj");
            registrationPattern.Validate("raj");
            registrationPattern.Validate("jo");
        }
    }
}

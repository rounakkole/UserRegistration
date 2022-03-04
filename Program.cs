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
            registrationPattern.Validate("Kohli");
            registrationPattern.Validate("tendulkar");
            registrationPattern.Validate("Dravid");
            registrationPattern.Validate("Li");
        }
    }
}

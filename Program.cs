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
            registrationPattern.Validate("abc.xyz@bi.co.in");
            registrationPattern.Validate("abc@bi.co");
            registrationPattern.Validate("ab@bi.co.in");
            registrationPattern.Validate("abc.xyz.co");
        }
    }
}

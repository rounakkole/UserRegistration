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
            //valid
            registrationPattern.Validate("abc@yahoo.com");
            registrationPattern.Validate("abc-100@yahoo.com");
            registrationPattern.Validate("abc.100@yahoo.com");
            registrationPattern.Validate("abc111@abc.com");
            registrationPattern.Validate("abc-100@abc.net");
            registrationPattern.Validate("abc.100@abc.com.au");
            registrationPattern.Validate("abc@1.com");
            registrationPattern.Validate("abc@gmail.com.com");
            registrationPattern.Validate("abc+100@gmail.com");
            //invalid
            registrationPattern.Validate("abc@.com.my");
            registrationPattern.Validate(".abc@abc.com");
            registrationPattern.Validate("abc@abc@gmail.com");
            registrationPattern.Validate("abc..2002@gmail.com");
            registrationPattern.Validate("abc@gmail.com.1a");
            registrationPattern.Validate("abc@gmail.com.aa.au");
            

        }
    }
}

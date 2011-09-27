using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter an email address or press [ENTER] to quit...");
                string emailAddress = Console.ReadLine();

                if (string.IsNullOrEmpty(emailAddress))
                    return;

                var svc = new EmailValidatorClient();
                bool result = svc.ValidateAddress(emailAddress);

                Console.WriteLine("Email address is valid : {0}", result);
            }
        }
    }
}

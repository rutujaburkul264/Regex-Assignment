using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            UC3_UserRegistration patterns = new UC3_UserRegistration();
           // Console.WriteLine(patterns.validatePinCode("Rutuja"));
            // Console.WriteLine(patterns.validatePinCode("Rutuja Burkul"));
             Console.WriteLine(patterns.validatePinCode("abc.xyz@bl.co.in"));
            // Console.WriteLine(patterns.validatePinCode("+917350473577"));

            Console.ReadKey();
        }
    }
}

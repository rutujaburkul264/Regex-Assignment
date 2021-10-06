using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            UC8_UserRegistration patterns = new UC8_UserRegistration();
           // Console.WriteLine(patterns.validatePinCode("Rutuja"));
            // Console.WriteLine(patterns.validatePinCode("Rutuja Burkul"));
            // Console.WriteLine(patterns.validatePinCode("abc.xyz@bl.co.in"));
            // Console.WriteLine(patterns.validatePinCode("+917350473577"));
	    // Console.WriteLine(patterns.validatePinCode("rutuja12"));
            // Console.WriteLine(patterns.validatePinCode("Rutuja12"));
            // Console.WriteLine(patterns.validatePinCode("Rutuja89"));
             Console.WriteLine(patterns.validatePinCode("Rutuja@9"));
            
            Console.ReadKey();
        }
    }
}

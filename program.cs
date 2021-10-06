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
            // Console.WriteLine(patterns.validatePinCode("Rutuja@9"));
	     Console.WriteLine(patterns.validatePinCode("abc@yahoo.com"));
            Console.WriteLine(patterns.validatePinCode("abc-100@yahoo.com"));
            Console.WriteLine(patterns.validatePinCode("abc.100@yahoo.com"));
            Console.WriteLine(patterns.validatePinCode("abc111@abc.com"));
            Console.WriteLine(patterns.validatePinCode("abc-100@abc.net"));
            Console.WriteLine(patterns.validatePinCode("abc.100@abc.com.au"));
            Console.WriteLine(patterns.validatePinCode("abc@1.com"));
            Console.WriteLine(patterns.validatePinCode("abc+100@gmail.com"));
	     
            
            Console.ReadKey();
        }
    }
}

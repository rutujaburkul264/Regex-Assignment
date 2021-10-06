using System;
using System.Text.RegularExpressions;
using System.Text;

namespace UserRegistrationProblem
{
    class UC5_UserRegistration
    {  
        //At least 8 characters
        string Regex_Pincode = "^.{8}$";
        public bool validatePinCode(string Password)
        {
            return Regex.IsMatch(Password, Regex_Pincode);
        }
    }
}

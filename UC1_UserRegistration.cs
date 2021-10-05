using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UC1_UserRegistration
    {
        string Regex_Pincode = "^[A-Z]{1}[a-z]+$";
        public bool validatePinCode(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_Pincode);
        }
    }
}

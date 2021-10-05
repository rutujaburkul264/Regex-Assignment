using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UC4_UserRegistration
    {
        string Regex_Pincode = "^[0-9]{2}[][0-9]{10}$";
        public bool validatePinCode(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, Regex_Pincode);
        }
    }
}


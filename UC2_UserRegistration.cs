using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UC2_UserRegistration
    {
        string Regex_Pincode = "^*[A-Z]{1}[a-z]+$";
        public bool validatePinCode(string pincode)
        {

            return Regex.IsMatch(pincode, Regex_Pincode);

        }
    }
}

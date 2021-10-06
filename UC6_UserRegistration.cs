using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UC6_UserRegistration
    {
        //Should have at least 1 uppercase
        string Regex_Pincode = "^(?=.*[A-Z]).{8}$";
        public bool validatePinCode(string Password)
        {
            return Regex.IsMatch(Password, Regex_Pincode);
        }
    }
}

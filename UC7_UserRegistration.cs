using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UC7_UserRegistration
    {
        //Should have at least one numeric number
        string Regex_Pincode = "^(?=.*[A-Z])(?=.*[0-9]).{8}$";
        public bool validatePinCode(string Password)
        {
            return Regex.IsMatch(Password, Regex_Pincode);
        }
    }
}

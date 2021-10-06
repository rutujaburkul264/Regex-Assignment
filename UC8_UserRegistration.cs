using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UC8_UserRegistration
    {
        //Has exactly 1 special charcter
        string Regex_Pincode = "^(?=*[A-Z])(?=*[0-9])(?=.*[@#$%].{8,8}$";
        public bool validatePinCode(string Password)
        {
            return Regex.IsMatch(Password, Regex_Pincode);
        }

    }
}

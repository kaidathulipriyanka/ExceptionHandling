using System;
using static UsingException_UserRegistrationProblem.Program;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingException_UserRegistrationProblem
{
    public class Persons
    {
        public static string GetValidEmail()
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (!IsValidEmail(email))
            {
                throw new Exception("Invalid Email!");
            }

            return email;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*(\.[a-zA-Z]{2,})$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }}}

       

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
     public static string GetValidPassword()
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (!IsValidPassword(password))
            {
                throw new Exception("Invalid Password!");
            }

            return password;
        }

        public static bool IsValidPassword(string password)
        {
            // Regular expressions for password rules
            string[] patterns = {
            @".{8,}",         // Minimum 8 characters
            @"[A-Z]",         // At least 1 uppercase letter
            @"\d",            // At least 1 numeric digit
            @"[^a-zA-Z0-9]"   // Exactly 1 special character
        };

            foreach (string pattern in patterns)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(password, pattern))
                {
                    return false;
                }
            }

            return true;
        }}}

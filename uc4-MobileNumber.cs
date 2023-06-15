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
     public static string GetValidMobile()
        {
            Console.Write("Enter Mobile: ");
            string mobile = Console.ReadLine();

            if (!IsValidMobile(mobile))
            {
                throw new Exception("Invalid Mobile!");
            }

            return mobile;
        }

        public static bool IsValidMobile(string mobile)
        {
            string pattern = @"^\d{2}\s\d{10}$";
            return System.Text.RegularExpressions.Regex.IsMatch(mobile, pattern);
        }}}

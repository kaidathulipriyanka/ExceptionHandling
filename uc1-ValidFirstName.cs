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
        public static string GetValidFirstName()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            if (string.IsNullOrEmpty(firstName) || firstName.Length < 3 || !char.IsUpper(firstName[0]))
            {
                throw new Exception("Invalid First Name!");
            }

            return firstName;
        }

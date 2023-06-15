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
        public static string GetValidLastName()
        {
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            if (string.IsNullOrEmpty(lastName) || lastName.Length < 3 || !char.IsUpper(lastName[0]))
            {
                throw new Exception("Invalid Last Name!");
            }

            return lastName;
        }}}

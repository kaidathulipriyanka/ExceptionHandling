namespace UsingException_UserRegistrationProblem
{
    public class Program  
    {
        static void Main(string[] args)
        {
            try
            {
                string firstName = GetValidFirstName();
                string lastName = GetValidLastName();
                string email = GetValidEmail();
                string mobile = GetValidMobile();
                string password = GetValidPassword();

                Console.WriteLine("User Registration Successful!");
                Console.WriteLine("First Name: " + firstName);
                Console.WriteLine("Last Name: " + lastName);
                Console.WriteLine("Email: " + email);
                Console.WriteLine("Mobile: " + mobile);
                Console.WriteLine("Password: " + password);
            }
            catch (Exception ex)
            {
                Console.WriteLine("User Registration Failed: " + ex.Message);
            }
        }

        private static string GetValidPassword()
        {
            throw new NotImplementedException();
        }

        private static string GetValidMobile()
        {
            throw new NotImplementedException();
        }

        private static string GetValidEmail()
        {
            throw new NotImplementedException();
        }

        private static string GetValidLastName()
        {
            throw new NotImplementedException();
        } 

        private static string GetValidFirstName()
        {
            throw new NotImplementedException();
        }   
    }
    }

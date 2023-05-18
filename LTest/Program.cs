using SimpleImpersonation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTest
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();

            var credentials = new UserCredentials("LUTC", username, ".");

            while (true)
            {
                try
                {
                    Impersonation.RunAsUser(credentials, LogonType.Network, () =>
                    {
                    });
                }
                catch
                {
                    Console.WriteLine("Locked!");
                }
            }
            Console.ReadLine();
        }
    }
}

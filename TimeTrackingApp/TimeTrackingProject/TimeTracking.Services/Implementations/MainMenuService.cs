using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Models;

namespace TimeTracking.Services.Implementations
{
    public class MainMenuService
    {
        public void DisplayMainMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Start Activity");
            Console.WriteLine("2. Stop Activity");
            Console.WriteLine("3. View User Activities");
            Console.WriteLine("4. Change Password");
            Console.WriteLine("5. Change First Name");
            Console.WriteLine("6. Change Last Name");
            Console.WriteLine("7. Deactivate Account");
            Console.WriteLine("8. Logout");
        }

        public void HandleMainMenuOption(int option)
        {
            switch (option)
            {
                case 1:
                    // Start Activity
                    break;
                case 2:
                    // Stop Activity
                    break;
                case 3:
                    // View User Activities
                    break;
                case 4:
                    // Change Password
                    break;
                case 5:
                    // Change First Name
                    break;
                case 6:
                    // Change Last Name
                    break;
                case 7:
                    // Deactivate Account
                    break;
                case 8:
                    // Logout
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}

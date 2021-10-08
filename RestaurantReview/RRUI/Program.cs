using System;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            //Polymorphism

            IMenu page = new MainMenu();

            while (repeat)
            {
                //Clean the screen on the terminal
                Console.Clear();
                page.Menu();
                MenuType currentPage = page.YourChoice();

                Console.WriteLine("Welcome to the Restaurant");
                //string userChoice;
                Console.WriteLine("[1] - Do you want to clear the screen?");
                Console.WriteLine("[2] - Do you want to exit out of the program?");
                //userChoice = Console.ReadLine();
                MainMenu test = new MainMenu();
                test.Menu();


                switch (currentPage)
                {
                    case MenuType.MainMenu:

                        page = new MainMenu();
                        break;

                    case MenuType.RestaurantMenu:
                        repeat = false;

                        break;
                    case MenuType.Exit:

                        Console.WriteLine("You have exited to the program!");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    default:

                        Console.WriteLine("You didn't add a menu in your enum!");

                        break;
                }
            }

        }
    }
}
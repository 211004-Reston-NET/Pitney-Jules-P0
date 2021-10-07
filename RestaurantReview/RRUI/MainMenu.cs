using System;

namespace RRUI
{
    // The ":" indicates that the class is inheriting from an interface. 
    class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] - Go to Restaurant");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {

                case "1":
                    return MenuType.RestaurantMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return MenuType.RestaurantMenu;


            }

        }
    }
}

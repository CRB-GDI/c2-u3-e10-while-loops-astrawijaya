namespace Exercise10AM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while ( choice != 4)
            { 

            // Print menu
            Console.WriteLine("**************");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine();

            //Ask the user for a choice
            Console.WriteLine("Please choose a number from the menu (1, 2, 3, or 4) ");
            choice = int.Parse(Console.ReadLine());
            //Console.WriteLine(choice);

            //Print message using if statements
            if (choice == 1)
                {
                    Console.WriteLine("Creating a new game... HEH!");
                }
            else if (choice == 2)
                {
                    Console.WriteLine("Loading game... zzz");
                }
            else if ( choice == 3)
                {
                    Console.WriteLine("Here are your options /jk");
                }
            else if ( choice > 4 || choice < 1)
                {
                    Console.WriteLine("Please type in 1, 2, 3, or 4");
                }

            }


        }
    }
}
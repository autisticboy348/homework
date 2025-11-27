using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You wake up in forest");
        Console.ReadKey();
        Console.Clear();

        bool isPlaying = true;
        int lifeChoices = 0;
        bool north = false;
        bool norther = false;

        while (isPlaying && lifeChoices < 6)
        {
            Console.WriteLine("What do you do?");

            if (!north && !norther)
            {
                Console.WriteLine("1 - Head north");
                Console.WriteLine("2 - Look around");
                Console.WriteLine("3 - Climb a tree");
                Console.WriteLine("4 - Exit game");
            }
            else if (!norther)
            {
                Console.WriteLine("1 - Keep heading north");
                Console.WriteLine("2 - Look around");
                Console.WriteLine("3 - Climb a tree");
                Console.WriteLine("4 - Exit game");
            }
            else
            {
                Console.WriteLine("1 - Keep heading north");
            }

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (!north && !norther)
                    {
                        Console.WriteLine("You head north");
                        Console.WriteLine("You are in the forest");
                        Console.WriteLine(" ");
                        Console.WriteLine("It has been thirty minutes");
                        Console.WriteLine("Your mother is waiting at the airport");
                        north = true;
                    }
                    else if (!norther)
                    {
                        Console.WriteLine("You continue to head north");
                        Console.WriteLine("It has been one hour");
                        Console.WriteLine("Dusk is falling near the airport");
                        Console.WriteLine("Your mother will be in the shadows soon");
                        norther = true;

                    }
                    else
                    {
                        Console.WriteLine("You continue head north");
                        Console.WriteLine("You are out of the forest");
                        Console.WriteLine("You're in the clearing");
                        Console.WriteLine("You're no longer in the forest");
                        Console.WriteLine("And therefore the vampires won");
                        Console.WriteLine("The End");
                        isPlaying = false;

                    }
                    break;

                case "2":
                    if (!north && !norther)
                    {
                        Console.WriteLine("You look around");
                        Console.WriteLine("You see forest");
                    }
                    else if (!norther)
                    {
                        Console.WriteLine("You look around");
                        Console.WriteLine("You see more forest");
                    }
                    break;

                case "3":
                    if (!north && !norther)
                    {
                        Console.WriteLine("You climbed tree");
                        Console.WriteLine("You see more forest");

                    }
                    else if (!norther)
                    {
                        Console.WriteLine("You climbed a tree");
                        Console.WriteLine("You see the forest");
                    }
                    break;

                case "4":
                    if (!north)
                    {
                        Console.WriteLine("Goodbye!");
                        isPlaying = false;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        isPlaying = false;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            lifeChoices++;

            if (north == true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
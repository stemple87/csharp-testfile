using System;

namespace Treehouse
{
    class Program
    {
        static void Main()
        {
            double runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {

                
                // Prompt the user for minutes exercised
                System.Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    try
                    {
                        double minutes = double.Parse(entry);

                        if(minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value.");
                            continue;
                        }
                        else if(minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing, am I right?");
                        }
                        else if(minutes <= 30)
                        {
                            Console.WriteLine("YWay to go hot stuff!");
                        }
                        else if(minutes <= 60)
                        {
                            Console.WriteLine("You must be a ninja warrior in training!");
                        }
                        else
                        {
                            Console.WriteLine("Okay, now you're just showing off!");
                        }


                        // Add minutes exercised to total
                        runningTotal = runningTotal + minutes;

                        // Display total minutes exercised to the screen
                        Console.WriteLine("You've exercised for " + runningTotal + " minutes");
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("That is not valid input.");
                        continue;
                    }

                }
                // Repeat until the user quits
            }
            Console.WriteLine("Goodbye");
        }
    }
}

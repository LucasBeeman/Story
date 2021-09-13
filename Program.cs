using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine().ToLower();
            Console.WriteLine(noiseChoice);
            if (noiseChoice == "no")
            {
                Console.WriteLine("\nNot much of an adventure if we don't leave our room! THE END.");
            }
            else if (noiseChoice == "yes")
            {
                Console.Write("\nYou walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?\n\n Type OPEN or KNOCK: ");
                string doorChoice = Console.ReadLine().ToLower();
                if (doorChoice == "knock")
                {
                    Console.Write("A voice behind the door speaks. It says, \"Answer this riddle: \" \"Poor people have it. Rich people need it. If you eat it you die. What is it?\" Type your answer: ");
                    string riddleAnswer = Console.ReadLine().ToLower();
                    if (riddleAnswer == "nothing")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door dosen't open.\nTHE END");
                    }
                }
                else if (doorChoice == "open")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number(1-3): ");
                    string keyChoice = Console.ReadLine();
                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Strange...\nTHE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
                            break;
                        default:
                            Console.WriteLine("You stoopid");
                            break;
                    }
                }
                {
                }
            }
            Console.ReadKey();
        }
    }
}
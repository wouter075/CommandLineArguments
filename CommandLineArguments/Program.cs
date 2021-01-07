using System;

namespace CommandLineArguments
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Before we start, make sure you set the commandline arguments in the proper way.
            // Rider: 
            // 1. Click in the menu on: Run
            // 2. Click in the Run menu on: Edit Configurations...
            // 3. Edit the "Program Arguments" properties
            
            
            // When you set the "Program Arguments" these arguments are then in the "args" array.
            // See: public static void Main(string[] args)
            
            // Some examples:
            
            // Count the numbers of arguments
            Console.WriteLine($"The number of arguments provided is: {args.Length}");
            
            // Print the arguments
            for (int x = 0; x < args.Length; x++)
            {
                Console.WriteLine($"args[{x}] has the value: {args[x]}");
            }
            
            // Check if the length is 2, and check if they are a value.
            if (args.Length == 2 && args[0] == "admin" && args[1] == "password")
            {
                Console.WriteLine("You are logged in!");
            }
        }
    }
}
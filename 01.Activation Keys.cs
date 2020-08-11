using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Generate")
            {
                string[] tokens = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                switch (command)
                {
                    case "Contains":
                        string substing = tokens[1];
                        if (key.Contains(substing))
                        {
                            Console.WriteLine($"{key} contains {substing}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }

                        break;
                    case "Flip":
                        var action = tokens[1];
                        var startIndex = int.Parse(tokens[2]);
                        var endIndex = int.Parse(tokens[3]);
                        if (action == "Upper")
                        {
                            key = key.Substring(0,startIndex)+ key.Substring(startIndex,endIndex-startIndex).ToUpper()+key.Substring(endIndex);
                            Console.WriteLine(key);
                        }
                        else
                        {
                            key = key.Substring(0, startIndex) + key.Substring(startIndex, endIndex-startIndex).ToLower() + key.Substring(endIndex);
                            Console.WriteLine(key);
                        }
                        break;
                    case "Slice":

                        var startIndexToRemove = int.Parse(tokens[1]);
                        var endIndexToRemove = int.Parse(tokens[2]);

                        key = key.Remove(startIndexToRemove, endIndexToRemove-startIndexToRemove);
                        Console.WriteLine(key);


                        break;

                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}

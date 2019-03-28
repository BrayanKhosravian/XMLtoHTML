using System;
using System.IO;

namespace XMLtoHTML.Services
{
    class InputManager : IInputManager
    {
        public string GetPath(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();

                if (String.IsNullOrEmpty(input)) Console.WriteLine("Input was null or empty!");
                else if (!File.Exists(input)) Console.WriteLine("File didnt exist!");
                else if (!input.EndsWith(".xml")) Console.WriteLine("File is not a .xml File!");
                else return input;
            }
           
        }

        public string GetParameters(string prompt)
        {
            throw new NotImplementedException();
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class CommandHandler
    {
        private string Command { get; set; }
        private List<int> Numbers = new() { };
        private string Flag { get; set; }
        public static bool Quit = false;

        public void SplitCommand()
        {
            string currentInput = Console.ReadLine();
            string[] buffer = currentInput.Split(' ');
            string[] numBuffer;

            Command = buffer[0];
            if (buffer.Last() == "-f")
            {
                Flag = buffer.Last();
                numBuffer = new string[buffer.Length - 2];
            }
            else
            {
                numBuffer = new string[buffer.Length - 1];
            }
            
            Array.Copy(buffer, 1, numBuffer, 0, numBuffer.Length);

            foreach (string strNumber in numBuffer)
            {
                int number = int.Parse(strNumber);
                Numbers.Add(number);
            }
        }

        public void ExecuteCommand()
        {
            switch (Command)
            {
                case "add":
                    Console.WriteLine(Calculator.AddNumbers(Numbers));
                    break;
                case "subtract":
                    Console.WriteLine(Calculator.SubtractNumbers(Numbers));
                    break;
                case "multiply":
                    Console.WriteLine(Calculator.MultiplyNumbers(Numbers));
                    break;
                case "quit":
                    Quit = true;
                    break;
                default:
                    Console.WriteLine("not a recognized command.");
                    break;
            }
        }

        public static void Run()
        {
            CommandHandler commandHandler = new CommandHandler();
            commandHandler.SplitCommand();
            commandHandler.ExecuteCommand();
        }
    }
}

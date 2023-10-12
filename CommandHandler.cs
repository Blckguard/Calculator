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
        private List<double> Numbers = new() { };
        private List<string> Operators = new() { };
        public static bool Quit = false;

        public void SplitCommand()
        {
            string currentInput = Console.ReadLine();
            char[] operatorChars = new char[4] { '+', '-', '*', '/' };
            string[] splitInput = currentInput.Split(' ');
            string[] splitNumbers = splitInput[1].Trim().Split(operatorChars);
            Command = splitInput[0];
            
            foreach (string character in splitNumbers)
            {
                if (character == "+" || character == "-" || character == "*" || character == "/")
                {
                    Operators.Add(character);
                }
                else
                {
                    Numbers.Add(double.Parse(character));
                }
            }
        }

        public void ExecuteCommand()
        {
            switch (Command)
            {
                case "calc":
                    Operator.Calculate();
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

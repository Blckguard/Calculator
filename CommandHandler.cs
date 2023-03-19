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
        private string CurrentCommand { get; set; }
        private List<int> Numbers = new() { };
        private string Flag { get; set; }
        public static bool QuitStatus = false;

        public void SplitCommand()
        {
            string currentInput = Console.ReadLine();
            string[] buffer = currentInput.Split(' ');
            string[] numBuffer = new string[buffer.Length - 1];

            CurrentCommand = buffer[0];
            if (buffer.Last().StartsWith("-"))
            {
                Flag = buffer.Last();
            }
            
            Array.Copy(buffer, 1, numBuffer, 0, numBuffer.Length);

            foreach (string strNumber in numBuffer)
            {
                int number = int.Parse(strNumber);
                Numbers.Add(number);
            }
        }

        public int HandleCommand()
        {
            if (CurrentCommand == "add") 
            {
                return Calculator.AddNumbers(Numbers);
            }
            if (CurrentCommand == "quit")
            {
                QuitStatus = true;
            }
            return 0;
        }

        public static void PrintResult()
        {
            CommandHandler commandHandler = new CommandHandler();
            commandHandler.SplitCommand();
            Console.WriteLine(commandHandler.HandleCommand());
        }
    }
}

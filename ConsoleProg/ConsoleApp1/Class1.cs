using System;
using System.IO;
using ColorCnsl1;

namespace HomeWork1
{
    public class ReadData : IExecutionAction
    {
        string IExecutionAction.ExecutionAction()
        {
            ReadFile();
            return "Press Enter";
        }
        private static void ReadFile()
        {
            ColorCnsl.Write("{=Yellow}Enter file path {/}\n");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch
            {
                ColorCnsl.Write("{=Red}Error. Invalid file path{/}\n");
            }
        }
    }
}

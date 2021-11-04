using System;
using HomeWork1;
using ColorCnsl1;

namespace ConsoleApp1
{



    class Program
    {
        static void Main()
        {
            string stop = "STOP";
            do
            {
                IActionUser action = new ActionUser();
                try
                {
                    ColorCnsl.Write("{=Yellow}-------------------------------{/}\n");
                    ColorCnsl.Write("{=Yellow}What do you want to choose? {/}\n");
                    ColorCnsl.Write("{=Yellow}Enter a number :\n 1 - Read file\n 2 - SQRT number\n 3 - Get HTML page <<yandex.ru>>{/}\n");
                    ColorCnsl.Write("{=Yellow}-------------------------------{/}\n");



                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x == 1)
                    {
                        action.GetActionUser(new ReadData());
                    }
                    else if (x == 2)
                    {
                        action.GetActionUser(new Calculation());
                    }
                    else if (x == 3)
                    {
                        action.GetActionUser(new GetHTML());
                    }
                    else if (x != 1 && x != 2 && x != 3)
                    {
                        ColorCnsl.Write("{=Red}Error. Select a number from the options provided{/}\n");
                    }

                }
                catch
                {
                    ColorCnsl.Write("{=Red}Error. Enter a number{/}\n");
                }

                ColorCnsl.Write("{=Yellow}Enter STOP to exit{/}\n");
                stop = Console.ReadLine();
            }
            while (stop != "STOP" && stop != "Stop" && stop != "stop");
        }
    }
}
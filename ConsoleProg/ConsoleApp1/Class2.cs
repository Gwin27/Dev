using System;
using ColorCnsl1;

namespace HomeWork1
{
    class Calculation : IExecutionAction
    {
        string IExecutionAction.ExecutionAction()
        {
            Calculat();
            return "Press Enter";
        }

        private void Calculat()
        {
            try
            {
                ColorCnsl.Write("{=Yellow}Enter the number{/}\n");
                double d = Convert.ToDouble(Console.ReadLine());
                if (d > 0)
                {
                    d = Math.Sqrt(d);
                    string s = Convert.ToString(d);
                    Console.Write("Sqrt of the entered number: {0} \n", s);
                }
                else
                {
                    ColorCnsl.Write("{=Red}Error. Number < 0{/}\n");
                }

            }
            catch
            {
                ColorCnsl.Write("{=Red}Error. Enter the number{/}\n");
            }
        }
    }
}
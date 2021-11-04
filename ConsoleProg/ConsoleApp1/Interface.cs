using System;

namespace HomeWork1
{
    interface IActionUser
    {
        void GetActionUser(IExecutionAction action);

    }
    interface IExecutionAction
    {
        string ExecutionAction();
    }
    class ActionUser : IActionUser
    {
        public void GetActionUser(IExecutionAction action)
        {
            Console.WriteLine(action.ExecutionAction());
        }
    }
}
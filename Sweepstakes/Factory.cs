using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Factory 
    {
        public static ISweepstakesManager ManagerSelect(string userInput)
        {
            ISweepstakesManager manager = null;
            switch (userInput)
            {
                case "STACK":
                    manager = new SweepstakesStackManager();
                    break;

                case "QUEUE":
                    manager = new SweepstakesQueueManager();
                    break;

                default:
                    UserInterface.DisplayInput("Please enter valid selection");
                    ManagerSelect(userInput);
                    break;
            }
            return manager;
        }
    }
}

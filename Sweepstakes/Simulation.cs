using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            string userInput = UserInterface.GetUserInputFor("Please choose:\n\nSTACK\n\nor\n\nQUEUE");
            switch (userInput.ToUpper())
            {
                case "STACK":
                    new MarketingFirm(_manager);
                    break;
                case "QUEUE":
                    new MarketingFirm();
                    break;
                default:
                    UserInterface.DisplayInput("Please enter valid selection");
                    CreateMarketingFirmWithManager();
                    break;
            }
        }
    }
}

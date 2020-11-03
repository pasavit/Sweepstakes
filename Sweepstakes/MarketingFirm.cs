using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            CreateSweepstakes();
        }

        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor("Name of Sweepstakes"));
            manager.InsertSweepstakes(sweepstakes);
            int contestants = UserInterface.GetIntUserInputFor("Enter amount of entries");
            for (int i = 0; i < contestants; i++)
            {
                Contestant newEntry = new Contestant();
                sweepstakes.RegisterContestant(newEntry);
            }
        }


    }
}

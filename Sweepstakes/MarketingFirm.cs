using System;

namespace Sweepstakes
{
    internal class MarketingFirm
    {
        private ISweepstakesManager manager;
        Sweepstakes sweepstakesName;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            CreateSweepstakes();
            WinningContestant();
        }

        public void CreateSweepstakes()
        {
            sweepstakesName = new Sweepstakes(UserInterface.GetUserInputFor("Enter name of your Sweepstakes"));
            manager.InsertSweepstakes(sweepstakesName);
            int contestants = UserInterface.GetIntUserInputFor("How many entries would you like to create?");
            for (int i = 0; i < contestants; i++)
            {
                if (i == 0)
                {
                    Contestant newEntry = new Contestant();
                    sweepstakesName.RegisterContestant(newEntry);
                }
                else
                {
                    UserInterface.DisplayInput("/nPlease enter next Contestants Info");
                    Contestant newEntry = new Contestant();
                    sweepstakesName.RegisterContestant(newEntry);
                }
            }
        }
        public void WinningContestant()
        {
            UserInterface.Clear();
            UserInterface.DisplayInput("THE WINNER IS:");
            sweepstakesName.PrintContestantInfo(manager.GetSweepstakes().PickWinner());
        }

    }
}
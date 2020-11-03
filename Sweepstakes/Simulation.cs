namespace Sweepstakes
{
    internal class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            MarketingFirm client = new MarketingFirm(Factory.ManagerSelect(TypeOfSweeps()));
        }
        public string TypeOfSweeps()
        {
            string managerType = UserInterface.GetUserInputFor("Please choose:\n\nSTACK\n\nor\n\nQUEUE");
            return managerType.ToUpper();
        }
        //public void CreateMarketingFirmWithManager()
        //{
        //    SweepstakesStackManager stack = new SweepstakesStackManager();
        //    SweepstakesQueueManager queue = new SweepstakesQueueManager();

        //    switch (TypeOfSweeps())
        //    {
        //        case "STACK":
        //            new MarketingFirm(stack);
        //            break;

        //        case "QUEUE":
        //            new MarketingFirm(queue);
        //            break;

        //        default:
        //            UserInterface.DisplayInput("Please enter valid selection");
        //            CreateMarketingFirmWithManager();
        //            break;
        //    }
        //}

    }
}
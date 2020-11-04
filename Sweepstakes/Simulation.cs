namespace Sweepstakes
{
    internal class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            UserInterface.Greeting();
            new MarketingFirm(Factory.ManagerSelect(TypeOfSweeps()));
        }
        public string TypeOfSweeps()
        {
            string managerType = UserInterface.GetUserInputFor("Please input:\n\nSTACK\nor\nQUEUE\n\n").ToUpper();
            if (managerType == "STACK")
            {
                return managerType;
            }
            else if (managerType == "QUEUE")
            {
                return managerType;
            }
            else
            {
                UserInterface.DisplayInput("Invalid input, please try again");
                return TypeOfSweeps();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant : INotify
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;
        public INotify Winner { get; set; }


        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor("\nEnter contestants first name");
            lastName = UserInterface.GetUserInputFor("\nEnter contestants last name");
            emailAddress = UserInterface.GetUserInputFor("\nEnter contestants email address");
        }

        public void Notify(INotify subscriber)
        {
            if (subscriber ==  Winner)
            {
                UserInterface.DisplayInput($"Congratulations{Winner}, you are the winner!");
            }
            else
            {
                UserInterface.DisplayInput($"The contest winner is {Winner}");
            }
        }
    }

}

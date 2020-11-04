using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor("\nEnter contestants first name");
            lastName = UserInterface.GetUserInputFor("\nEnter contestants last name");
            emailAddress = UserInterface.GetUserInputFor("\nEnter contestants email address");
        }
    }

}

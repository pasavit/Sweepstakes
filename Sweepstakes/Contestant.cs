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
            firstName = UserInterface.GetUserInputFor("Enter first name");
            lastName = UserInterface.GetUserInputFor("Enter last name");
            emailAddress = UserInterface.GetUserInputFor("Enter email address");
        }
    }

}

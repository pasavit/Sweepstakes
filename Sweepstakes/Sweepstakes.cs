using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes 
    {
        private Dictionary<int, Contestant> contestants;
        private List<INotify> subscribers = new List<INotify>();
        private Random rng = new Random();
        private string name;
        public string Name { get; set; }


        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count + 1, contestant);
            contestant.registrationNumber = contestants.Count;
            subscribers.Add(contestant);
        }

        public Contestant PickWinner()
        {
            int winner = rng.Next(1, contestants.Count());
            var winningContestant = contestants[winner];
            NotifySubscribers();
            return winningContestant;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayInput($"First Name: {contestant.firstName}");
            UserInterface.DisplayInput($"Last Name: {contestant.lastName}");
            UserInterface.DisplayInput($"Email Address: {contestant.emailAddress}");
            UserInterface.DisplayInput($"Registration Number: {contestant.registrationNumber}");
        }

        private void NotifySubscribers()
        {
            foreach (INotify contestant in subscribers)
            {
                contestant.Notify(contestant);
            }
        }
    }
}

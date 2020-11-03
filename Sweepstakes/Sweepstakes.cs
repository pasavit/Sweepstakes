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
            contestant.registrationNumber = contestants.Count + 1;
        }

        public Contestant PickWinner()
        {
            int winner = rng.Next(1, contestants.Count());
            return contestants[winner];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayInput(contestant.firstName);
            UserInterface.DisplayInput(contestant.lastName);
            UserInterface.DisplayInput(contestant.emailAddress);
            UserInterface.DisplayInput(contestant.registrationNumber);
        }

    }
}

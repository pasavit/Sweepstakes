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
        private string name;
        public string Name { get; set; }

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count + 1, contestant);
        }

        //public Contestant PickWinner()
        //{
        //    foreach(Contestant in contestants)
        //    return winner;
        //}

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayInput(contestant.firstName);
            UserInterface.DisplayInput(contestant.lastName);
            UserInterface.DisplayInput(contestant.emailAddress);

        }

        public Contestant NewEntry()
        {
            Contestant newEntry = new Contestant();

            return newEntry;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            name = Name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Reistration Number: {contestant.RegistrationNumber}" );
            Console.WriteLine($"First Name {contestant.FirstName}");
            Console.WriteLine($"Last Name {contestant.LastName}");
            Console.WriteLine($"Email {contestant.EmailAddress}");
        }

    }
}

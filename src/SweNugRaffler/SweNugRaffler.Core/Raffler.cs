using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweNugRaffler.Core
{
    public class Raffler
    {
        private IList<string> _entrants;

        public IList<string> Entrants
        {
            get { return _entrants; }
            private set { _entrants = value; }
        }

        public Raffler()
        {
            _entrants = new List<string>();
        }

        public void AddEntrant(string entrant)
        {
            _entrants.Add(entrant);
        }

        public int NumberOfEntrants()
        {
            return _entrants.Count;
        }

        public string GetRandomWinner()
        {
            return GetWinner();
        }

        private string GetWinner()
        {
            var random = new Random(DateTime.Now.Millisecond);

            var winnerIndex = random.Next(0, _entrants.Count - 1);

            return _entrants[winnerIndex];
        }
    }
}

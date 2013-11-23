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
    }
}

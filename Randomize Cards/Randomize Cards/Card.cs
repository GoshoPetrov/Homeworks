using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Cards
{
    internal class Card
    {
        public string Face { get; set; }

        public string Suite { get; set; }

        public Card(string fase, string suite)
        {
            this.Face = fase;
            this.Suite = suite;
        }
        public string Print()
        {
            return $"{Face} {Suite}";
        }
    }
}

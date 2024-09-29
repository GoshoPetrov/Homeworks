using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Card
{
    internal class Card
    {
        public string Face { get; set; } // 8

        public string Suite { get; set; } // Spades

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

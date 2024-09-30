using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
    class Card
    {
        public string Color { get; set; }
        public string Number { get; set; }
        public int Value { get; set; }

        public Card(string color, string number)
        {
            this.Color = color;
            this.Number = number;

            int value;
            if (int.TryParse(number, out value))
            {
                this.Value = value;
            }
            else
            {
                switch (number)
                {
                    case "J":
                    case "Q":
                    case "K":
                        this.Value = 10;
                        break;
                    case "A":
                        this.Value = 11;
                        break;
                    default:
                        this.Value = 0;
                        break;
                }
            }
        }
    }
}

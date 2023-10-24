using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletyGSU
{
    public class Ticket
    {
        public int Номер { get; set; }
        public string Вопрос1 { get; set; }
        public string Вопрос2 { get; set; }

        public Ticket(int index, string first, string second)
        {
            Номер = index;
            Вопрос1 = first;
            Вопрос2 = second;
        }

    }
}

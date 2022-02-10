using System;
using System.Collections.Generic;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Casino Casino = new Casino();

            Managers Mana = new Managers(1, "Mana");

            Programmers Harry = new Programmers(1, "Harry");
        }
    }
}
using System;
using System.Collections.Generic;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Casino Casino = new Casino();

            Managers Mana = new Managers();

            Programmers Harry = new Programmers();

            Harry.Name = Harry;
            Harry.Id = 2;

            Mana.Id = 1;
            Mana.Name = Mana;
        }
    }
}
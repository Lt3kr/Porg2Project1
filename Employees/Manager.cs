using System;

namespace Casino
{
    class Managers : Employees
    {
        private HireEmployee()
        {
            if(Console.ReadLine("Dealers"))
            {
                Dealers dealer1 = new Dealers();
            }
            else if(Console.ReadLine("Programmers"))
            {
                Programmers programmer = new Programmers();
            }
        }
        private FireEmployee()
        {
            int ID = int.Parse(Console.Read());

            Employees.RemoveEmployee(ID);
        }
        private CheckEmployee(int id)
        { 
            
        }
        public new Managers(int id, string Name)
        {

        }
    }
}
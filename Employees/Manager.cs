using System;

namespace Casino
{
    class Managers : Employees
    {
        private HireEmployee()
        {
            
        }
        private FireEmployee()
        {
            int ID = int.Parse(Console.Read());

            Employees.RemoveEmployee(ID);
        }

        private CheckEmployee(int id)
        { 
            
        }

    }
}
using System;

namespace Casino
{
    class Programmers : Employees
    {
        int ProgrammersID = this.Id;
        public ProgramCasino()
        {
            
        }
        public LeaveCasino()
        {
            Employees.RemoveEmployee(ProgrammersID);
        }
    }
}
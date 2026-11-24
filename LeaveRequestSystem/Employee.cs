using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestSystem
{
    public class Employee : Person 
    {
        public string Password { get; set; }

        public Employee(int id, string name, string password)
        {
            ID = id;
            Name = name;
            Password = password;
        }
    }
}

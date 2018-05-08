using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement
{
    public class Computer
    {
        private int computerID;
        private string type;
        private bool compStatus;
        private int computerLabID;

        public Computer(int cid, string t, bool cs, int clid)
        {
            computerID = cid;
            type = t;
            compStatus = cs;
            computerLabID = clid;
        }

        public int getComputerID()
        {
            return computerID;
        }

        public string getComputerType()
        {
            return type;
        }

        public bool getCompStatus()
        {
            return compStatus;  
        }

        public int getComputerLabID()
        {
            return computerLabID;
        }
    }
}

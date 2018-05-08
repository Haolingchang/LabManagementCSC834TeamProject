using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement
{
    public class Lab
    {
        private int labID;
        private string labName;
        private int availableComp = 0;
        private bool projector;
        private bool printer;
        private string schedule;
        private bool labStatus;
        private int labCapacity;

        public Lab(int id, string name, bool proj, bool p, bool status, string s, int c)
        {
            labID = id;
            labName = name;
            projector = proj;
            printer = p;
            schedule = s;
            labStatus = status;
            labCapacity = c;
        }

        public int getLabID()
        {
            return labID;
        }

        public string getLabName()
        {
            return labName;
        }

        public int getAvailableComp()
        {
            return availableComp;
        }

        public bool getProjector()
        {
            return projector;
        }

        public bool getPrinter()
        {
            return printer;
        }

        public string getSchedule()
        {
            return schedule;
        }

        public bool getLabStatus()
        {
            return labStatus;
        }

        public int getCapacity()
        {
            return labCapacity;
        }

        public void setAvailableComp(int availcomp)
        {
            availableComp = availcomp;
        }
    }
}

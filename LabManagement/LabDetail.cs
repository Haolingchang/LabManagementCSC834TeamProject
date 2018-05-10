using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagement
{
    public partial class LabDetail : Form
    {
        Lab selectedL;
        public LabDetail()
        {
            InitializeComponent();
        }

        public LabDetail(Lab sL)
        {
            InitializeComponent();
            selectedL = sL;
            refreshDisplay(selectedL);
        }

        public void refreshDisplay(Lab selectedLab)
        {
            ConnectDB db = new ConnectDB();
            label1.Text = selectedLab.getLabName().ToUpper();
            List<Button> computersList = this.panel1.Controls.OfType<Button>().ToList();
            List<Computer> computerList = db.getComputers(selectedLab);

            computersList.Reverse();

            //setup computers =========================================================================
            foreach (Button b in computersList)
                b.Hide();
            for (int i = 0; i < selectedLab.getCapacity(); i++)
            {
                computersList.ElementAt(i).Show();
                computersList.ElementAt(i).Text = computerList.ElementAt(i).getComputerID().ToString();

                if (computerList.ElementAt(i).getCompStatus())
                    computersList.ElementAt(i).BackColor = Color.Green;
                else
                    computersList.ElementAt(i).BackColor = Color.Red;
            }
            //==========================================================================================

            //setup detail information =================================================================
            capacityBox.Text = selectedLab.getCapacity().ToString() + " computers are in this lab";

            if (selectedLab.getPrinter())
                printerBox.Text = "Printer is available";
            else
                printerBox.Text = "No printer is in this lab";

            if (selectedLab.getProjector())
            {
                projectorBox.Text = "Projector is available";
            }
            else
                projectorBox.Text = "No projector is in this lab";
            if(selectedLab.getAvailableComp() > 1)
                availableC.Text = selectedLab.getAvailableComp().ToString() + " computers are available";
            else
                availableC.Text = selectedLab.getAvailableComp().ToString() + " computer is available";
            //============================================================================================

            //setup schedule
            scheduleBox.Clear();
            string[] s;
            s = selectedL.getSchedule().Split(',');
            foreach(string ss in s)
            {
                
                scheduleBox.AppendText(ss+"\n");
            }

        }

        private void refreshDetail_Click(object sender, EventArgs e)
        {
            refreshDisplay(selectedL);
        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            int compIDLogin = 0;
            try {compIDLogin = int.Parse(compIDText.Text);
                int status = 0;
                ConnectDB db = new ConnectDB();
                db.updateComputerTable(compIDLogin, status);
                MessageBox.Show("Loggin successfully!");
            }
            catch { MessageBox.Show("Please enter a computerID"); }
            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            int compIDLogout = 0;
            try { compIDLogout = int.Parse(compIDText.Text);
                int status = 1;
                ConnectDB db = new ConnectDB();
                db.updateComputerTable(compIDLogout, status);
                MessageBox.Show("Logout successfully!");
            }
            catch  { MessageBox.Show("Please enter a computer ID"); }
            
        }

        private bool firstime = true;
        private void compIDText_Enter(object sender, EventArgs e)
        {
            if (firstime)
            {
                compIDText.Clear();
                firstime = false;
            }
        }
    }
}

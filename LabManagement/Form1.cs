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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            RefreshDisplay();
        }

        //private variable
        private List<Lab> labList = new List<Lab>();

        private void RefreshDisplay()
        {
            configureButtons();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshDisplay();
        }

        //display detail information of a lab
        private void Detail1_Click(object sender, EventArgs e)
        {
            //pass a Lab object to constructor
            LabDetail dForm;
            foreach(Lab l in labList)
            {
                if (B1.Text.ToLower().Contains(l.getLabName().ToLower()))
                {
                    dForm = new LabDetail(l);
                    dForm.ShowDialog();
                    break;
                }
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            String[] s;

            scheduleRichBox.Clear();
            foreach (Lab l in labList)
            {
                if (b1.Text.ToLower().Contains(l.getLabName().ToLower()))
                {
                    s = l.getSchedule().Split(',');
                    for (int i = 0; i < s.Length; i++)
                    {
                        
                        scheduleRichBox.AppendText(s[i]+"\n");
                    }
                    break;
                }
            }
        }

        private void configureButtons(string sortoption = "default")
        {
            List<Button> labButtonList = this.panel1.Controls.OfType<Button>().ToList();
            labButtonList.Reverse();
            int incre = 0;

            ConnectDB dbconn = new ConnectDB();

            String buttonName = "";

            labList = dbconn.getLabs();

            if (sortoption.Equals("D"))
            {
                labList.Sort((x, y) => y.getAvailableComp().CompareTo(x.getAvailableComp()));
            }
            else if (sortoption.Equals("A"))
            {
                labList.Sort((x, y) => x.getAvailableComp().CompareTo(y.getAvailableComp()));
            }

            foreach (Lab alab in labList)
            {
                if (alab.getLabStatus() && alab.getAvailableComp() > 0)
                {
                    labButtonList.ElementAt(incre).BackColor = Color.Green;
                    if (alab.getAvailableComp() > 1)
                        buttonName = alab.getLabName().ToUpper() + ": " + alab.getAvailableComp().ToString() + " Computers are available";
                    else
                        buttonName = alab.getLabName().ToUpper() + ": " + alab.getAvailableComp().ToString() + " Computer is available";
                    labButtonList.ElementAt(incre).Text = buttonName;
                }
                else if (!(alab.getAvailableComp() > 0))
                {
                    labButtonList.ElementAt(incre).BackColor = Color.Red;
                    buttonName = alab.getLabName().ToUpper() + " is full";
                    labButtonList.ElementAt(incre).Text = buttonName;
                }
                else
                {
                    labButtonList.ElementAt(incre).BackColor = Color.Red;
                    buttonName = alab.getLabName().ToUpper() + " is in use, please check the lab schedule";
                    labButtonList.ElementAt(incre).Text = buttonName;
                }
                incre++;
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            String[] s;
            scheduleRichBox.Clear();

            foreach (Lab l in labList)
            {
                if (b1.Text.ToLower().Contains(l.getLabName().ToLower()))
                {
                    s = l.getSchedule().Split(',');
                    for (int i = 0; i < s.Length; i++)
                    {
                        
                        scheduleRichBox.AppendText(s[i]+"\n");
                    }
                    break;
                }
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            String[] s;
            scheduleRichBox.Clear();

            foreach (Lab l in labList)
            {
                if (b1.Text.ToLower().Contains(l.getLabName().ToLower()))
                {
                    s = l.getSchedule().Split(',');
                    for (int i = 0; i < s.Length; i++)
                    {
                        
                        scheduleRichBox.AppendText(s[i]+"\n");
                    }
                    break;
                }
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            String[] s;

            scheduleRichBox.Clear();
            foreach (Lab l in labList)
            {
                if (b1.Text.ToLower().Contains(l.getLabName().ToLower()))
                {
                    s = l.getSchedule().Split(',');
                    for (int i = 0; i < s.Length; i++)
                    {
                        
                        scheduleRichBox.AppendText(s[i]+"\n");
                    }
                    break;
                }
            }
        }

        private void d2_Click(object sender, EventArgs e)
        {
            //pass a Lab object to constructor
            LabDetail dForm;
            foreach (Lab l in labList)
            {
                if (B2.Text.ToLower().Contains(l.getLabName().ToLower()))
                {
                    dForm = new LabDetail(l);
                    dForm.ShowDialog();
                    break;
                }
            }
        }

        private void d3_Click(object sender, EventArgs e)
        {
            //pass a Lab object to constructor
            LabDetail dForm;
            foreach (Lab l in labList)
            {
                if (B3.Text.ToLower().Contains(l.getLabName().ToLower()))
                {
                    dForm = new LabDetail(l);
                    dForm.ShowDialog();
                    break;
                }
            }
        }

        private void d4_Click(object sender, EventArgs e)
        {
            //pass a Lab object to constructor
            LabDetail dForm;
            foreach (Lab l in labList)
            {
                if (B4.Text.ToLower().Contains(l.getLabName().ToLower()))
                {
                    dForm = new LabDetail(l);
                    dForm.ShowDialog();
                    break;
                }
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            List<RadioButton> options = this.sortOptionBox.Controls.OfType<RadioButton>().ToList();
            string selectedOption = "";
            foreach(RadioButton op in options)
            {
                if (op.Checked)
                {
                    if(op.Name.Equals("compDRB"))
                    {
                        selectedOption = "D";
                    }
                    else
                    {
                        selectedOption = "A";
                    }
                }
            }

            configureButtons(selectedOption);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LabManagement
{
    class ConnectDB
    {
        private MySqlConnection connection = null;

        public ConnectDB()
        {
            Initialize();
        }

        private void Initialize()
        {
            string connectionString = @"server=csdatabase.eku.edu;userid=tang;password=KKADCM;database=tang;SslMode=none";
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                CloseConnection();
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server!");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password!");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //return number of available computers
        public int GetAvailableComp(int labID)
        {
            string query = "select * from computers";

            //int computerID = 0;
            //string compType = "";
            bool compStatus = true;
            int computerLabID = 0;
            int availableComp = 0;
            //List<Computer> comps = new List<Computer>();

            if(OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    //computerID = (int)dataReader.GetInt32("computerID");
                    //compType = dataReader.GetString("type");
                    compStatus = dataReader.GetBoolean("compStatus");
                    computerLabID = dataReader.GetInt32("computerLabID");

                    if (compStatus && computerLabID == labID)
                    {
                        //Computer comp = new Computer(computerID, compType, compStatus, computerLabID);
                        //comps.Add(comp);
                        availableComp++;
                    }
                     
                }
                
            }
            CloseConnection();
            return availableComp;
        }

        //return a list of labs 
        public List<Lab> getLabs()
        {
            List<Lab> labs = new List<Lab>();

            int labid = 0;
            string name = "";
            bool proj = true;
            bool printer = true;
            string sche = "";
            bool status = true;
            int capacity = 0;
            string query = "select * from labs";

            if(OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    labid = reader.GetInt32(0);
                    name = reader.GetString(1);
                    

                    if (reader.GetInt32(2) == 1)
                        proj = true;
                    else
                        proj = false;
                    if (reader.GetInt32(3) == 1)
                        printer = true;
                    else
                        printer = false;

                    sche = reader.GetString(4);

                    if (reader.GetInt32(5) == 1)
                        status = true;
                    else
                        status = false;
                    capacity = reader.GetInt32(6);

                    Lab aLab = new Lab(labid, name, proj, printer, status, sche, capacity);

                    labs.Add(aLab);
                }
            }
            foreach(Lab l in labs)
            {
                l.setAvailableComp(GetAvailableComp(l.getLabID()));
            }
            
            return labs;
        }

        //return a list of computers
        public List<Computer> getComputers(Lab l)
        {
            List<Computer> computers = new List<Computer>();

            int cID = 0;
            string cType = "";
            bool cStatus = true;
            int cLID = 0;

            string query = "select * from computers";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cID = reader.GetInt32(0);
                    cType = reader.GetString(1);
                    if (reader.GetInt32(2) == 1)
                        cStatus = true;

                    else
                        cStatus = false;
                    cLID = reader.GetInt32(3);

                    if (cLID == l.getLabID())
                    { 
                    Computer aComputer = new Computer(cID, cType, cStatus, cLID);
                    computers.Add(aComputer);
                    }
                }
            }
            CloseConnection();
            return computers;
        }

        //update computers table
        public void updateComputerTable(int compIDLL, int status)
        {
            string query = "update computers set compStatus = ?status where computerID = ?id ";
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("?status", status);
                cmd.Parameters.AddWithValue("?id", compIDLL);
                cmd.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }

}

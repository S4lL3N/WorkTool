using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using WorkTool.Logic;
using WorkTool.UI.Properties;

namespace WorkTool.UI
{
    public partial class InfoForm : Form
    {
        //string pathToJSONData = @"C:\Users\S4lL3\Desktop\WorkTool\JSONCountyData";
        string pathToJSONData = Settings.Default["JSONPath"].ToString();
        public string databaseSoftware { get; set; }

        public InfoForm()
        {
            InitializeComponent();
        }

        public static List<County> ReadJson(string pathToJSON)
        {
            List<County> Counties;

            try
            {
                string input = File.ReadAllText(pathToJSON);
                Counties = JsonConvert.DeserializeObject<List<County>>(input);
                return Counties;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "\nCouldn't open JSON DIrectory: Change JSON Path in Settings.");
            }
            return null;
            
        }

        public void findInfo(string stateIN, string countyIN)
        {
            List<County> searchCounties = new List<County>();
            if (stateIN.Equals("AR"))
            {
                searchCounties = ReadJson(pathToJSONData + @"\AR.json");
            }
            if (stateIN.Equals("KY"))
            {
                searchCounties = ReadJson(pathToJSONData + @"\KY.json");
            }
            if (stateIN.Equals("NC"))
            {
                searchCounties = ReadJson(pathToJSONData + @"\NC.json");
            }
            if (stateIN.Equals("SC"))
            {
                searchCounties = ReadJson(pathToJSONData + @"\SC.json");
            }
            if (stateIN.Equals("TN"))
            {
                searchCounties = ReadJson(pathToJSONData + @"\TN.json");
            }
            if (stateIN.Equals("VA"))
            {
                searchCounties = ReadJson(pathToJSONData + @"\VA.json");
            }
            
            if (searchCounties != null)
            {
                for (int i = 0; i < searchCounties.Count; i++)
                {
                    if (countyIN.Equals(searchCounties[i].county))
                    {
                        County_Label.Text = searchCounties[i].county;
                        State_Label.Text = searchCounties[i].state;
                        OS_Label.Text = searchCounties[i].os;
                        NumberTextBox.Text = searchCounties[i].number;
                        Database_Label.Text= searchCounties[i].database;
                        databaseSoftware = searchCounties[i].database;
                        SQLForm.SetDatabaseSoftware(databaseSoftware);
                        AddressTextBox.Text = searchCounties[i].address;
                        UsernameTextBox.Text = searchCounties[i].username;
                        PasswordTextBox.Text = searchCounties[i].password;
                    }
                }
            }

        }

    

        public void clearForm()
        {
            County_Label.Text = "";
            State_Label.Text = "";
            OS_Label.Text = "";
            NumberTextBox.Text = "";
            AddressTextBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }


        public string SetStateLabelText
        {
            get { return this.State_Label.Text; }
            set { this.State_Label.Text = value; }
        }

        private void Database_Label_Click(object sender, EventArgs e)
        {

        }
    }
}

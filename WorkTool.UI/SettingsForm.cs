using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTool.UI.Properties;


namespace WorkTool.UI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LogTextBox.Visible = false;
            SaveLogButton.Visible = false;
            JSONTextBox.Visible = false;
            JSONSaveButton.Visible = false;
            Log_Path_Label.Text = Settings.Default["LogFilePath"].ToString();
            JSON_Path_Label.Text = Settings.Default["JSONPath"].ToString();
            


        }

        private void Log_Path_Label_Click(object sender, EventArgs e)
        {

        }

        private void LogTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeLogButton_Click(object sender, EventArgs e)
        {
            SaveLogButton.Visible = true;
            LogTextBox.Visible = true;

        }

        private void SaveLogButton_Click(object sender, EventArgs e)
        {
            Settings.Default["LogFilePath"] = LogTextBox.Text;
            Log_Path_Label.Text = LogTextBox.Text;
            Settings.Default.Save();
            SaveLogButton.Visible = false;
            LogTextBox.Visible = false;
            MessageBox.Show("Restart LRTool for Changes to take effect.");
        }

        private void JSON_Path_Label_Click(object sender, EventArgs e)
        {

        }

        private void JSONTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void JSONChangeButton_Click(object sender, EventArgs e)
        {
            JSONSaveButton.Visible=true;
            JSONTextBox.Visible = true;
            

        }

        private void JSONSaveButton_Click(object sender, EventArgs e)
        {
            Settings.Default["JSONPath"] = JSONTextBox.Text;
            JSON_Path_Label.Text = JSONTextBox.Text;
            Settings.Default.Save();
            JSONTextBox.Visible = false;
            JSONSaveButton.Visible = false;
            MessageBox.Show("Restart LRTool for Changes to take effect.");
        }
    }
}

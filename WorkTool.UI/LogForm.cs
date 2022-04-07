using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using WorkTool.UI.Properties;
using System.Diagnostics;
using WorkTool.Logic;

namespace WorkTool.UI
{
    public partial class LogForm : Form
    {
        string caller = "";
        string county = "";
        string state = "";
        string problem = "";
        string solution = "";
        string callDuration = "";
        int characterReturnLength = 160;
        //string pathToLogFile = @"C:\Users\S4lL3\Desktop\WorkTool\LogFile.txt";
        string pathToLogFile = Settings.Default["LogFilePath"].ToString();
        InfoForm infoForm = new InfoForm();
        Stopwatch stopwatch;
        bool instBox = false;
        bool batchbox = false;
        

        public string instNum { get; set; }
        public string batchNum { get; set; }


        public LogForm()
        {
            InitializeComponent();
            ARComboBox.Visible = false;
            KYComboBox.Visible = false;
            NCComboBox.Visible = false;
            SCComboBox.Visible = false;
            TNComboBox.Visible = false;
            VAComboBox.Visible = false;
            TimerLabel.Visible = false;
            Inst_textBox.ForeColor = Color.Red;
            Inst_textBox.TextAlign = HorizontalAlignment.Center;
            Inst_textBox.Text = "Instrument #";
            Batch_textBox.ForeColor = Color.Red;
            Batch_textBox.TextAlign = HorizontalAlignment.Center;
            Batch_textBox.Text = "Batch #";
        }

        private void CallerTextBox_TextChanged(object sender, EventArgs e)
        {
            caller = CallerTextBox.Text;
            stopwatch = Stopwatch.StartNew();
            TimerLabel.Visible = true;

        }

        private void ARRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ARRadioButton.Checked)
            {
                ARComboBox.Enabled = true;
                ARComboBox.Visible = true;
                state = "AR";
            }
            else
            {
                ARComboBox.Visible = false;
                ARComboBox.Enabled = false;
            }
        }

        private void KYRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (KYRadioButton.Checked)
            {
                KYComboBox.Enabled = true;
                KYComboBox.Visible = true;
                state = "KY";
            }
            else
            {
                KYComboBox.Visible = false;
                KYComboBox.Enabled = false;
            }
        }

        private void NCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NCRadioButton.Checked)
            {
                NCComboBox.Enabled = true;
                NCComboBox.Visible = true;
                state = "NC";
            }
            else
            {
                NCComboBox.Visible = false;
                NCComboBox.Enabled = false;
            }
        }

        private void SCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SCRadioButton.Checked)
            {
                SCComboBox.Enabled = true;
                SCComboBox.Visible = true;
                state = "SC";
            }
            else
            {
                SCComboBox.Visible = false;
                SCComboBox.Enabled = false;
            }
        }

        private void TNRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TNRadioButton.Checked)
            {
                TNComboBox.Enabled = true;
                TNComboBox.Visible = true;
                county = TNComboBox.Text;
                state = "TN";

            }
            else
            {
                TNComboBox.Visible = false;
                TNComboBox.Enabled = false;
            }
        }

        private void VARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (VARadioButton.Checked)
            {
                VAComboBox.Enabled = true;
                VAComboBox.Visible = true;
                state = "VA";
            }
            else
            {
                VAComboBox.Visible = false;
                VAComboBox.Enabled = false;
            }
        }

        private void ARComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            county = ARComboBox.Text;
            infoForm.findInfo(state, county);
        }

        private void KYComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            county = KYComboBox.Text;
            infoForm.findInfo(state, county);
        }

        private void NCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            county = NCComboBox.Text;
            infoForm.findInfo(state, county);
        }

        private void SCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            county = SCComboBox.Text;
            infoForm.findInfo(state, county);
        }

        private void TNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            county = TNComboBox.Text;
            infoForm.findInfo(state, county);
        }

        private void VAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            county = VAComboBox.Text;
            infoForm.findInfo(state, county);
        }

        private void ProblemRichTextBox_TextChanged(object sender, EventArgs e)
        {
            problem = SpliceText(ProblemRichTextBox.Text, characterReturnLength);
        }

        private void SolutionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            solution = SpliceText(SolutionRichTextBox.Text, characterReturnLength);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ARRadioButton.Checked = false;
            KYRadioButton.Checked = false;
            NCRadioButton.Checked = false;
            SCRadioButton.Checked = false;
            TNRadioButton.Checked = false;
            VARadioButton.Checked = false;
            ARComboBox.Text = "";
            KYComboBox.Text = "";
            NCComboBox.Text = "";
            SCComboBox.Text = "";
            TNComboBox.Text = "";
            VAComboBox.Text = "";
            SolutionRichTextBox.Text = "";
            ProblemRichTextBox.Text = "";
            CallerTextBox.Text = "";
            TimerLabel.Visible = false;
            Inst_textBox.ForeColor = Color.Red;
            Inst_textBox.TextAlign = HorizontalAlignment.Center;
            Inst_textBox.Text = "Instrument #";
            Batch_textBox.ForeColor = Color.Red;
            Batch_textBox.TextAlign = HorizontalAlignment.Center;
            Batch_textBox.Text = "Batch #";
            instBox = false;
            batchbox = false;



        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            LogCall();
            ARRadioButton.Checked = false;
            KYRadioButton.Checked = false;
            NCRadioButton.Checked = false;
            SCRadioButton.Checked = false;
            TNRadioButton.Checked = false;
            VARadioButton.Checked = false;
            ARComboBox.Text = "";
            KYComboBox.Text = "";
            NCComboBox.Text = "";
            SCComboBox.Text = "";
            TNComboBox.Text = "";
            VAComboBox.Text = "";
            SolutionRichTextBox.Text = "";
            ProblemRichTextBox.Text = "";
            CallerTextBox.Text = "";
            infoForm.clearForm();
            TimerLabel.Visible = false;
            Inst_textBox.ForeColor = Color.Red;
            Inst_textBox.TextAlign = HorizontalAlignment.Center;
            Inst_textBox.Text = "Instrument #";
            Batch_textBox.ForeColor = Color.Red;
            Batch_textBox.TextAlign = HorizontalAlignment.Center;
            Batch_textBox.Text = "Batch #";
            instBox = false;
            batchbox = false;
        }

        public void LogCall()
        {
            DateTime dt = DateTime.Now;

            using (StreamWriter sw = File.AppendText(@pathToLogFile))
            {
                //sw.WriteLine("=============================================================================");
                sw.WriteLine("Status: " + "!Done");
                sw.WriteLine("Date: " + Convert.ToString(dt.DayOfWeek) + ": " + Convert.ToString(dt));
                sw.WriteLine("Caller: " + caller);
                sw.WriteLine("Call Duration: " + callDuration);
                sw.WriteLine("County: " + county + ", " + state);
                sw.WriteLine("Problem: \n" + problem);
                sw.WriteLine("Solution: \n" + solution);
                sw.WriteLine("/*========================================================================================================================================================*/");
            }
        }

        public string SpliceText(string text, int lineLength)
        {
            return Regex.Replace(text, "(.{" + lineLength + "})", "$1" + Environment.NewLine);
        }
        public InfoForm getInfoForm
        {
            get { return infoForm; }
            set { infoForm = value; }
        }

        public string getLogPath
        {
            get { return pathToLogFile; }
            set { pathToLogFile = value; }
        }

        private void CallTimer_Tick(object sender, EventArgs e)
        {
            
            if(stopwatch != null)
            {
                string time = String.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
                TimerLabel.Text = time;
                callDuration = time;
            }
            else
            {
                TimerLabel.Visible = false;
            }
            

        }

        private void Inst_textBox_TextChanged(object sender, EventArgs e)
        {
            instNum = Inst_textBox.Text;
        }

        private void Batch_textBox_TextChanged(object sender, EventArgs e)
        {
            batchNum = Batch_textBox.Text;
        }
       
        private void Inst_textBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(instBox == false)
            {
                Inst_textBox.ForeColor = Color.White;
                Inst_textBox.Text = "";
                instBox = true;
            }
            
        }

        private void Batch_textBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (batchbox == false)
            {
                Batch_textBox.ForeColor = Color.White;
                Batch_textBox.Text = "";
                batchbox = true;
            }
            
        }
        
    }
}

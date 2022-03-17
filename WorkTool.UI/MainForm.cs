using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTool.UI
{
    public partial class MainForm : Form
    {
        private Form activeform = null;
        private LogForm logForm = new LogForm();
        private SQLForm sqlForm = new SQLForm();
        private InfoForm infoForm = new InfoForm();
        private SettingsForm settingsForm = new SettingsForm();

        public MainForm()
        {
            InitializeComponent();
            //LogForm logForm = new LogForm();
            //logForm.Show();
            //SQLForm sqlForm = new SQLForm();
            //sqlForm.Show();
            //InfoForm infoForm = new InfoForm();
            //infoForm.Show();
        }

        
        private void openPanel(Form childForm)
        {
            greetingsLabel.Visible = false;
            GreetingLabel2.Visible = false;
            if (activeform != null)
            {
                activeform.Visible = false;

            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //add the panel to show the form
            DisplayPanel.Controls.Add(childForm);
            DisplayPanel.Tag = childForm;
            childForm.Show();
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            openPanel(logForm);
        }

        private void SQLButton_Click(object sender, EventArgs e)
        {
            sqlForm.setSQLInst(logForm.instNum);
            sqlForm.setSQLBatch(logForm.batchNum);
            openPanel(sqlForm);
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            infoForm = logForm.getInfoForm;
            openPanel(infoForm);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            openPanel(settingsForm);
        }

        public LogForm getLoggingForm
        {
            get { return logForm; }
            set { logForm = value; }
        }

        public SQLForm getSQLForm
        {
            get { return sqlForm; }
            set { sqlForm = value; }
        }
    }
}

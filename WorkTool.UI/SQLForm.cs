using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTool.Logic;

namespace WorkTool.UI
{
    public partial class SQLForm : Form
    {
        Boolean instnum = false;
        Boolean batchnum = false;
        Boolean tracking = false;
        string comboBoxValue;
        string batchNumber;
        string _instrument;
        string trackingNum;
        


        public SQLForm()
        {
            InitializeComponent();
            Batch_textBox.Visible = false;
            Tracking_textBox.Visible = false;
            Tracking_checkBox.Visible = false;
            

        }

      

        private void CommandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommandComboBox.Text.Equals("EFile via Tracking Num."))
            {
                Tracking_checkBox.Visible = true;
                Tracking_checkBox.Checked = true;
                Tracking_textBox.Visible = true;

            }
            else
            {
                Tracking_checkBox.Visible = false;
                Tracking_textBox.Visible = false;
            }
        }

        private void InstCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            instnum = InstCheckBox.Checked;
        }

        private void BatchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            batchnum = BatchCheckBox.Checked;
            if (batchnum)
            {
                Batch_textBox.Visible = true;
            }
            else
            {
                Batch_textBox.Visible = false;
            }
            
        }
        private void Tracking_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tracking_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //tracking = Tracking_checkBox.Checked;
            //if (tracking)
            //{
            //    Tracking_textBox.Visible = true;
            //}
            //else
            //{
            //    Tracking_textBox.Visible = false;
            //}
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            KeyTextBox.Text = "";
            InstCheckBox.Checked = false;
            BatchCheckBox.Checked = false;
            Tracking_textBox.Visible = false;
            Tracking_checkBox.Visible = false;
            CommandComboBox.Text = "";
            StatmentRichTextBox.Text = "";
        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            StatmentRichTextBox.Text = GenerateStatement();
        }

        private void StatmentRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Batch_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GenButton.PerformClick();
            }
        }

        public void setSQLInst(string inst)
        {
            if (inst.Equals("Instrument #"))
            {
                KeyTextBox.Text = "";

            }
            else
            {
                KeyTextBox.Text = inst;
                InstCheckBox.Checked = true;

            }

        }
        public void setSQLBatch(string batch)
        {
            if (batch.Equals("Batch #"))
            {
                Batch_textBox.Text = "";

            }
            else
            {
                Batch_textBox.Text = batch;
                BatchCheckBox.Checked = true;

            }

        }

        private String GenerateStatement()
        {
            
            string output;

            comboBoxValue = CommandComboBox.Text;
            _instrument = KeyTextBox.Text;
            batchNumber = Batch_textBox.Text;
            trackingNum = Tracking_textBox.Text;

            
            if (comboBoxValue.Equals("Transactions") && InstCheckBox.Checked && BatchCheckBox.Checked)
            {
                
                output = SQLStatements.Transactions(_instrument, batchNumber);
                //saves to clipboard
                Clipboard.SetText(output);
                return output;
            }
            if (comboBoxValue.Equals("Transactions") && instnum)
            {

                output = SQLStatements.TransactionsInst(_instrument);
                //saves to clipboard
                Clipboard.SetText(output);
                return output;
            }
            if (comboBoxValue.Equals("Transactions") && BatchCheckBox.Checked)
            {

                output = SQLStatements.TransactionsBatch(batchNumber);
                //saves to clipboard
                Clipboard.SetText(output);
                return output;
            }
            if (comboBoxValue.Equals("EFile") && BatchCheckBox.Checked)
            {

                output = SQLStatements.EfileBatch(batchNumber);
                //saves to clipboard
                Clipboard.SetText(output);
                return output;
            }
            if (comboBoxValue.Equals("EFile") && InstCheckBox.Checked)
            {

                output = SQLStatements.EfileInst(_instrument);
                //saves to clipboard
                Clipboard.SetText(output);
                return output;
            }
            else
            {
                output = "";
                return output;
            }
            
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}

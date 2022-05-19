namespace WorkTool.UI
{
    partial class SQLForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.DatabaseButton = new System.Windows.Forms.Button();
            this.Tracking_checkBox = new System.Windows.Forms.CheckBox();
            this.Tracking_textBox = new System.Windows.Forms.TextBox();
            this.Batch_textBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.BatchCheckBox = new System.Windows.Forms.CheckBox();
            this.InstCheckBox = new System.Windows.Forms.CheckBox();
            this.CommandComboBox = new System.Windows.Forms.ComboBox();
            this.GenButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatmentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OptionsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.DatabaseButton);
            this.OptionsPanel.Controls.Add(this.Tracking_checkBox);
            this.OptionsPanel.Controls.Add(this.Tracking_textBox);
            this.OptionsPanel.Controls.Add(this.Batch_textBox);
            this.OptionsPanel.Controls.Add(this.KeyTextBox);
            this.OptionsPanel.Controls.Add(this.BatchCheckBox);
            this.OptionsPanel.Controls.Add(this.InstCheckBox);
            this.OptionsPanel.Controls.Add(this.CommandComboBox);
            this.OptionsPanel.Controls.Add(this.GenButton);
            this.OptionsPanel.Controls.Add(this.ClearButton);
            this.OptionsPanel.Location = new System.Drawing.Point(15, 40);
            this.OptionsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(892, 340);
            this.OptionsPanel.TabIndex = 0;
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DatabaseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.DatabaseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatabaseButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.DatabaseButton.Location = new System.Drawing.Point(26, 254);
            this.DatabaseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Size = new System.Drawing.Size(153, 66);
            this.DatabaseButton.TabIndex = 5;
            this.DatabaseButton.Text = "Open DB";
            this.DatabaseButton.UseVisualStyleBackColor = false;
            this.DatabaseButton.Click += new System.EventHandler(this.DatabaseButton_Click);
            // 
            // Tracking_checkBox
            // 
            this.Tracking_checkBox.AutoSize = true;
            this.Tracking_checkBox.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tracking_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.Tracking_checkBox.Location = new System.Drawing.Point(26, 179);
            this.Tracking_checkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tracking_checkBox.Name = "Tracking_checkBox";
            this.Tracking_checkBox.Size = new System.Drawing.Size(268, 26);
            this.Tracking_checkBox.TabIndex = 4;
            this.Tracking_checkBox.Text = "Tracking number:";
            this.Tracking_checkBox.UseVisualStyleBackColor = true;
            this.Tracking_checkBox.CheckedChanged += new System.EventHandler(this.Tracking_checkBox_CheckedChanged);
            // 
            // Tracking_textBox
            // 
            this.Tracking_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Tracking_textBox.Font = new System.Drawing.Font("Conthrax Sb", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tracking_textBox.ForeColor = System.Drawing.Color.White;
            this.Tracking_textBox.Location = new System.Drawing.Point(336, 179);
            this.Tracking_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tracking_textBox.Name = "Tracking_textBox";
            this.Tracking_textBox.Size = new System.Drawing.Size(210, 36);
            this.Tracking_textBox.TabIndex = 3;
            this.Tracking_textBox.TextChanged += new System.EventHandler(this.Tracking_textBox_TextChanged);
            this.Tracking_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyTextBox_KeyDown);
            // 
            // Batch_textBox
            // 
            this.Batch_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Batch_textBox.Font = new System.Drawing.Font("Conthrax Sb", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batch_textBox.ForeColor = System.Drawing.Color.White;
            this.Batch_textBox.Location = new System.Drawing.Point(336, 132);
            this.Batch_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Batch_textBox.Name = "Batch_textBox";
            this.Batch_textBox.Size = new System.Drawing.Size(210, 36);
            this.Batch_textBox.TabIndex = 3;
            this.Batch_textBox.TextChanged += new System.EventHandler(this.Batch_textBox_TextChanged);
            this.Batch_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyTextBox_KeyDown);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.KeyTextBox.Font = new System.Drawing.Font("Conthrax Sb", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextBox.ForeColor = System.Drawing.Color.White;
            this.KeyTextBox.Location = new System.Drawing.Point(336, 86);
            this.KeyTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(210, 36);
            this.KeyTextBox.TabIndex = 3;
            this.KeyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            this.KeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyTextBox_KeyDown);
            // 
            // BatchCheckBox
            // 
            this.BatchCheckBox.AutoSize = true;
            this.BatchCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BatchCheckBox.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.BatchCheckBox.Location = new System.Drawing.Point(26, 132);
            this.BatchCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BatchCheckBox.Name = "BatchCheckBox";
            this.BatchCheckBox.Size = new System.Drawing.Size(225, 26);
            this.BatchCheckBox.TabIndex = 2;
            this.BatchCheckBox.Text = "Batch number";
            this.BatchCheckBox.UseVisualStyleBackColor = false;
            this.BatchCheckBox.CheckedChanged += new System.EventHandler(this.BatchCheckBox_CheckedChanged);
            // 
            // InstCheckBox
            // 
            this.InstCheckBox.AutoSize = true;
            this.InstCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.InstCheckBox.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.InstCheckBox.Location = new System.Drawing.Point(26, 86);
            this.InstCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InstCheckBox.Name = "InstCheckBox";
            this.InstCheckBox.Size = new System.Drawing.Size(305, 26);
            this.InstCheckBox.TabIndex = 2;
            this.InstCheckBox.Text = "Instrument number";
            this.InstCheckBox.UseVisualStyleBackColor = false;
            this.InstCheckBox.CheckedChanged += new System.EventHandler(this.InstCheckBox_CheckedChanged);
            // 
            // CommandComboBox
            // 
            this.CommandComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandComboBox.FormattingEnabled = true;
            this.CommandComboBox.Items.AddRange(new object[] {
            "Transactions",
            "EFile",
            "EFile via Tracking Num.",
            "Image Details",
            "Change Password",
            "Master Settings",
            "Printer and Term Setup",
            "Certification date"});
            this.CommandComboBox.Location = new System.Drawing.Point(26, 19);
            this.CommandComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CommandComboBox.Name = "CommandComboBox";
            this.CommandComboBox.Size = new System.Drawing.Size(285, 33);
            this.CommandComboBox.TabIndex = 1;
            this.CommandComboBox.SelectedIndexChanged += new System.EventHandler(this.CommandComboBox_SelectedIndexChanged);
            // 
            // GenButton
            // 
            this.GenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.GenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.GenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.GenButton.Location = new System.Drawing.Point(719, 254);
            this.GenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(153, 66);
            this.GenButton.TabIndex = 0;
            this.GenButton.Text = "Generate";
            this.GenButton.UseVisualStyleBackColor = false;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.ClearButton.Location = new System.Drawing.Point(559, 254);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(153, 66);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.StatmentRichTextBox);
            this.panel2.Location = new System.Drawing.Point(6, 388);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 535);
            this.panel2.TabIndex = 1;
            // 
            // StatmentRichTextBox
            // 
            this.StatmentRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatmentRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.StatmentRichTextBox.Font = new System.Drawing.Font("Conthrax Sb", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatmentRichTextBox.ForeColor = System.Drawing.Color.White;
            this.StatmentRichTextBox.Location = new System.Drawing.Point(9, 4);
            this.StatmentRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatmentRichTextBox.Name = "StatmentRichTextBox";
            this.StatmentRichTextBox.Size = new System.Drawing.Size(883, 505);
            this.StatmentRichTextBox.TabIndex = 0;
            this.StatmentRichTextBox.Text = "";
            this.StatmentRichTextBox.TextChanged += new System.EventHandler(this.StatmentRichTextBox_TextChanged);
            // 
            // SQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(920, 926);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OptionsPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SQLForm";
            this.Text = "SQLForm";
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox CommandComboBox;
        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.CheckBox BatchCheckBox;
        private System.Windows.Forms.CheckBox InstCheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox StatmentRichTextBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox Batch_textBox;
        private System.Windows.Forms.TextBox Tracking_textBox;
        private System.Windows.Forms.CheckBox Tracking_checkBox;
        private System.Windows.Forms.Button DatabaseButton;
    }
}
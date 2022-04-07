namespace WorkTool.UI
{
    partial class LogForm
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
            this.components = new System.ComponentModel.Container();
            this.CallerLabel = new System.Windows.Forms.Label();
            this.ProbSolPanel = new System.Windows.Forms.Panel();
            this.Batch_textBox = new System.Windows.Forms.TextBox();
            this.Inst_textBox = new System.Windows.Forms.TextBox();
            this.ProblemRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SolutionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SolutionLabel = new System.Windows.Forms.Label();
            this.ProblemLabel = new System.Windows.Forms.Label();
            this.StateCountyPanel = new System.Windows.Forms.Panel();
            this.VAComboBox = new System.Windows.Forms.ComboBox();
            this.TNComboBox = new System.Windows.Forms.ComboBox();
            this.SCComboBox = new System.Windows.Forms.ComboBox();
            this.NCComboBox = new System.Windows.Forms.ComboBox();
            this.KYComboBox = new System.Windows.Forms.ComboBox();
            this.ARComboBox = new System.Windows.Forms.ComboBox();
            this.VARadioButton = new System.Windows.Forms.RadioButton();
            this.TNRadioButton = new System.Windows.Forms.RadioButton();
            this.SCRadioButton = new System.Windows.Forms.RadioButton();
            this.NCRadioButton = new System.Windows.Forms.RadioButton();
            this.KYRadioButton = new System.Windows.Forms.RadioButton();
            this.ARRadioButton = new System.Windows.Forms.RadioButton();
            this.CallerTextBox = new System.Windows.Forms.TextBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.CallTimer = new System.Windows.Forms.Timer(this.components);
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ProbSolPanel.SuspendLayout();
            this.StateCountyPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CallerLabel
            // 
            this.CallerLabel.AutoSize = true;
            this.CallerLabel.Font = new System.Drawing.Font("Sea-Dog Italic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.CallerLabel.Location = new System.Drawing.Point(38, 50);
            this.CallerLabel.Name = "CallerLabel";
            this.CallerLabel.Size = new System.Drawing.Size(187, 27);
            this.CallerLabel.TabIndex = 0;
            this.CallerLabel.Text = "Caller:";
            // 
            // ProbSolPanel
            // 
            this.ProbSolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProbSolPanel.Controls.Add(this.Batch_textBox);
            this.ProbSolPanel.Controls.Add(this.Inst_textBox);
            this.ProbSolPanel.Controls.Add(this.ProblemRichTextBox);
            this.ProbSolPanel.Controls.Add(this.SolutionRichTextBox);
            this.ProbSolPanel.Controls.Add(this.SolutionLabel);
            this.ProbSolPanel.Controls.Add(this.ProblemLabel);
            this.ProbSolPanel.Location = new System.Drawing.Point(14, 176);
            this.ProbSolPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProbSolPanel.Name = "ProbSolPanel";
            this.ProbSolPanel.Size = new System.Drawing.Size(888, 630);
            this.ProbSolPanel.TabIndex = 1;
            // 
            // Batch_textBox
            // 
            this.Batch_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Batch_textBox.Font = new System.Drawing.Font("Conthrax Sb", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batch_textBox.ForeColor = System.Drawing.Color.White;
            this.Batch_textBox.Location = new System.Drawing.Point(676, 21);
            this.Batch_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Batch_textBox.Name = "Batch_textBox";
            this.Batch_textBox.Size = new System.Drawing.Size(200, 36);
            this.Batch_textBox.TabIndex = 2;
            this.Batch_textBox.TextChanged += new System.EventHandler(this.Batch_textBox_TextChanged);
            this.Batch_textBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Batch_textBox_MouseDown);
            // 
            // Inst_textBox
            // 
            this.Inst_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Inst_textBox.Font = new System.Drawing.Font("Conthrax Sb", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inst_textBox.ForeColor = System.Drawing.Color.White;
            this.Inst_textBox.Location = new System.Drawing.Point(420, 21);
            this.Inst_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Inst_textBox.Name = "Inst_textBox";
            this.Inst_textBox.Size = new System.Drawing.Size(249, 36);
            this.Inst_textBox.TabIndex = 2;
            this.Inst_textBox.TextChanged += new System.EventHandler(this.Inst_textBox_TextChanged);
            this.Inst_textBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inst_textBox_MouseDown);
            // 
            // ProblemRichTextBox
            // 
            this.ProblemRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ProblemRichTextBox.Font = new System.Drawing.Font("Conthrax Sb", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemRichTextBox.ForeColor = System.Drawing.Color.White;
            this.ProblemRichTextBox.Location = new System.Drawing.Point(29, 76);
            this.ProblemRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProblemRichTextBox.Name = "ProblemRichTextBox";
            this.ProblemRichTextBox.Size = new System.Drawing.Size(847, 146);
            this.ProblemRichTextBox.TabIndex = 1;
            this.ProblemRichTextBox.Text = "";
            this.ProblemRichTextBox.TextChanged += new System.EventHandler(this.ProblemRichTextBox_TextChanged);
            // 
            // SolutionRichTextBox
            // 
            this.SolutionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolutionRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SolutionRichTextBox.Font = new System.Drawing.Font("Conthrax Sb", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionRichTextBox.ForeColor = System.Drawing.Color.White;
            this.SolutionRichTextBox.Location = new System.Drawing.Point(29, 294);
            this.SolutionRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SolutionRichTextBox.Name = "SolutionRichTextBox";
            this.SolutionRichTextBox.Size = new System.Drawing.Size(847, 332);
            this.SolutionRichTextBox.TabIndex = 1;
            this.SolutionRichTextBox.Text = "";
            this.SolutionRichTextBox.TextChanged += new System.EventHandler(this.SolutionRichTextBox_TextChanged);
            // 
            // SolutionLabel
            // 
            this.SolutionLabel.AutoSize = true;
            this.SolutionLabel.Font = new System.Drawing.Font("Sea-Dog Italic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.SolutionLabel.Location = new System.Drawing.Point(25, 248);
            this.SolutionLabel.Name = "SolutionLabel";
            this.SolutionLabel.Size = new System.Drawing.Size(215, 27);
            this.SolutionLabel.TabIndex = 0;
            this.SolutionLabel.Text = "Solution";
            // 
            // ProblemLabel
            // 
            this.ProblemLabel.AutoSize = true;
            this.ProblemLabel.Font = new System.Drawing.Font("Sea-Dog Italic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.ProblemLabel.Location = new System.Drawing.Point(25, 32);
            this.ProblemLabel.Name = "ProblemLabel";
            this.ProblemLabel.Size = new System.Drawing.Size(216, 27);
            this.ProblemLabel.TabIndex = 0;
            this.ProblemLabel.Text = "Problem";
            // 
            // StateCountyPanel
            // 
            this.StateCountyPanel.Controls.Add(this.VAComboBox);
            this.StateCountyPanel.Controls.Add(this.TNComboBox);
            this.StateCountyPanel.Controls.Add(this.SCComboBox);
            this.StateCountyPanel.Controls.Add(this.NCComboBox);
            this.StateCountyPanel.Controls.Add(this.KYComboBox);
            this.StateCountyPanel.Controls.Add(this.ARComboBox);
            this.StateCountyPanel.Controls.Add(this.VARadioButton);
            this.StateCountyPanel.Controls.Add(this.TNRadioButton);
            this.StateCountyPanel.Controls.Add(this.SCRadioButton);
            this.StateCountyPanel.Controls.Add(this.NCRadioButton);
            this.StateCountyPanel.Controls.Add(this.KYRadioButton);
            this.StateCountyPanel.Controls.Add(this.ARRadioButton);
            this.StateCountyPanel.Location = new System.Drawing.Point(18, 100);
            this.StateCountyPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StateCountyPanel.Name = "StateCountyPanel";
            this.StateCountyPanel.Size = new System.Drawing.Size(891, 89);
            this.StateCountyPanel.TabIndex = 2;
            // 
            // VAComboBox
            // 
            this.VAComboBox.FormattingEnabled = true;
            this.VAComboBox.Items.AddRange(new object[] {
            "Scott",
            "Smyth"});
            this.VAComboBox.Location = new System.Drawing.Point(739, 39);
            this.VAComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VAComboBox.Name = "VAComboBox";
            this.VAComboBox.Size = new System.Drawing.Size(136, 28);
            this.VAComboBox.TabIndex = 1;
            this.VAComboBox.SelectedIndexChanged += new System.EventHandler(this.VAComboBox_SelectedIndexChanged);
            // 
            // TNComboBox
            // 
            this.TNComboBox.FormattingEnabled = true;
            this.TNComboBox.Items.AddRange(new object[] {
            "Anderson",
            "Bedford",
            "Bledsoe",
            "Bradley",
            "Campbell",
            "Carter",
            "Claiborne",
            "Clay",
            "Cocke",
            "Coffee",
            "Cumberland",
            "Davidson",
            "Decatur",
            "Fayette",
            "Fentress",
            "Franklin",
            "Giles",
            "Grainger",
            "Greene",
            "Hamblen",
            "Hawkins",
            "Hickman",
            "Humphreys",
            "Jackson",
            "Jefferson",
            "Johnson",
            "Lawrence",
            "Lincoln",
            "Louden",
            "Macon",
            "Madison",
            "Marion",
            "Maury",
            "Monroe",
            "Moore",
            "Perry",
            "Pickett",
            "Polk",
            "Rhea",
            "Roane",
            "Scott",
            "Sequatchie",
            "Sevier",
            "Shelby",
            "Smith",
            "sullivan",
            "Unicoi",
            "Union",
            "Van Buren",
            "Washington",
            "Weakly",
            "White",
            "Williamson",
            "Wilson"});
            this.TNComboBox.Location = new System.Drawing.Point(596, 39);
            this.TNComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TNComboBox.Name = "TNComboBox";
            this.TNComboBox.Size = new System.Drawing.Size(136, 28);
            this.TNComboBox.TabIndex = 1;
            this.TNComboBox.SelectedIndexChanged += new System.EventHandler(this.TNComboBox_SelectedIndexChanged);
            // 
            // SCComboBox
            // 
            this.SCComboBox.FormattingEnabled = true;
            this.SCComboBox.Items.AddRange(new object[] {
            "Aiken",
            "Berkeley",
            "Calhoun",
            "Colleton",
            "Dorchester",
            "Georgetown",
            "Lancaster",
            "Laurens",
            "Spartanburg",
            "York"});
            this.SCComboBox.Location = new System.Drawing.Point(453, 39);
            this.SCComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SCComboBox.Name = "SCComboBox";
            this.SCComboBox.Size = new System.Drawing.Size(136, 28);
            this.SCComboBox.TabIndex = 1;
            this.SCComboBox.SelectedIndexChanged += new System.EventHandler(this.SCComboBox_SelectedIndexChanged);
            // 
            // NCComboBox
            // 
            this.NCComboBox.FormattingEnabled = true;
            this.NCComboBox.Items.AddRange(new object[] {
            "Anson",
            "Avery",
            "Clay",
            "Columbus",
            "Davidson",
            "Forsyth",
            "Guilford",
            "Haywood",
            "Macon",
            "McDowell",
            "Mitchell",
            "New Hanover",
            "Robeson",
            "Transylvania",
            "Yancy"});
            this.NCComboBox.Location = new System.Drawing.Point(310, 39);
            this.NCComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NCComboBox.Name = "NCComboBox";
            this.NCComboBox.Size = new System.Drawing.Size(136, 28);
            this.NCComboBox.TabIndex = 1;
            this.NCComboBox.SelectedIndexChanged += new System.EventHandler(this.NCComboBox_SelectedIndexChanged);
            // 
            // KYComboBox
            // 
            this.KYComboBox.FormattingEnabled = true;
            this.KYComboBox.Items.AddRange(new object[] {
            "Breckinridge",
            "Henderson",
            "Hopkins",
            "Jackson",
            "Jefferson",
            "Kenton",
            "Nelson",
            "Owen"});
            this.KYComboBox.Location = new System.Drawing.Point(168, 39);
            this.KYComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KYComboBox.Name = "KYComboBox";
            this.KYComboBox.Size = new System.Drawing.Size(136, 28);
            this.KYComboBox.TabIndex = 1;
            this.KYComboBox.SelectedIndexChanged += new System.EventHandler(this.KYComboBox_SelectedIndexChanged);
            // 
            // ARComboBox
            // 
            this.ARComboBox.FormattingEnabled = true;
            this.ARComboBox.Items.AddRange(new object[] {
            "Ashley",
            "Baxter",
            "Benton",
            "Bradley",
            "Chicot",
            "Cleburne",
            "Cleveland",
            "Crawford",
            "Dallas",
            "Desha",
            "Dewitt",
            "Faulkner",
            "Green",
            "Independence",
            "Johnson",
            "Madison",
            "Pulaski",
            "Searcy",
            "Stone",
            "Stuttgart",
            "Van Buren",
            "White"});
            this.ARComboBox.Location = new System.Drawing.Point(25, 39);
            this.ARComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ARComboBox.Name = "ARComboBox";
            this.ARComboBox.Size = new System.Drawing.Size(136, 28);
            this.ARComboBox.TabIndex = 1;
            this.ARComboBox.SelectedIndexChanged += new System.EventHandler(this.ARComboBox_SelectedIndexChanged);
            // 
            // VARadioButton
            // 
            this.VARadioButton.AutoSize = true;
            this.VARadioButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VARadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.VARadioButton.Location = new System.Drawing.Point(778, 4);
            this.VARadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VARadioButton.Name = "VARadioButton";
            this.VARadioButton.Size = new System.Drawing.Size(71, 26);
            this.VARadioButton.TabIndex = 0;
            this.VARadioButton.TabStop = true;
            this.VARadioButton.Text = "VA";
            this.VARadioButton.UseVisualStyleBackColor = true;
            this.VARadioButton.CheckedChanged += new System.EventHandler(this.VARadioButton_CheckedChanged);
            // 
            // TNRadioButton
            // 
            this.TNRadioButton.AutoSize = true;
            this.TNRadioButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.TNRadioButton.Location = new System.Drawing.Point(638, 4);
            this.TNRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TNRadioButton.Name = "TNRadioButton";
            this.TNRadioButton.Size = new System.Drawing.Size(66, 26);
            this.TNRadioButton.TabIndex = 0;
            this.TNRadioButton.TabStop = true;
            this.TNRadioButton.Text = "TN";
            this.TNRadioButton.UseVisualStyleBackColor = true;
            this.TNRadioButton.CheckedChanged += new System.EventHandler(this.TNRadioButton_CheckedChanged);
            // 
            // SCRadioButton
            // 
            this.SCRadioButton.AutoSize = true;
            this.SCRadioButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.SCRadioButton.Location = new System.Drawing.Point(490, 4);
            this.SCRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SCRadioButton.Name = "SCRadioButton";
            this.SCRadioButton.Size = new System.Drawing.Size(66, 26);
            this.SCRadioButton.TabIndex = 0;
            this.SCRadioButton.TabStop = true;
            this.SCRadioButton.Text = "SC";
            this.SCRadioButton.UseVisualStyleBackColor = true;
            this.SCRadioButton.CheckedChanged += new System.EventHandler(this.SCRadioButton_CheckedChanged);
            // 
            // NCRadioButton
            // 
            this.NCRadioButton.AutoSize = true;
            this.NCRadioButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.NCRadioButton.Location = new System.Drawing.Point(346, 4);
            this.NCRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NCRadioButton.Name = "NCRadioButton";
            this.NCRadioButton.Size = new System.Drawing.Size(66, 26);
            this.NCRadioButton.TabIndex = 0;
            this.NCRadioButton.TabStop = true;
            this.NCRadioButton.Text = "NC";
            this.NCRadioButton.UseVisualStyleBackColor = true;
            this.NCRadioButton.CheckedChanged += new System.EventHandler(this.NCRadioButton_CheckedChanged);
            // 
            // KYRadioButton
            // 
            this.KYRadioButton.AutoSize = true;
            this.KYRadioButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KYRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.KYRadioButton.Location = new System.Drawing.Point(205, 4);
            this.KYRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KYRadioButton.Name = "KYRadioButton";
            this.KYRadioButton.Size = new System.Drawing.Size(68, 26);
            this.KYRadioButton.TabIndex = 0;
            this.KYRadioButton.TabStop = true;
            this.KYRadioButton.Text = "KY";
            this.KYRadioButton.UseVisualStyleBackColor = true;
            this.KYRadioButton.CheckedChanged += new System.EventHandler(this.KYRadioButton_CheckedChanged);
            // 
            // ARRadioButton
            // 
            this.ARRadioButton.AutoSize = true;
            this.ARRadioButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.ARRadioButton.Location = new System.Drawing.Point(57, 4);
            this.ARRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ARRadioButton.Name = "ARRadioButton";
            this.ARRadioButton.Size = new System.Drawing.Size(70, 26);
            this.ARRadioButton.TabIndex = 0;
            this.ARRadioButton.TabStop = true;
            this.ARRadioButton.Text = "AR";
            this.ARRadioButton.UseVisualStyleBackColor = true;
            this.ARRadioButton.CheckedChanged += new System.EventHandler(this.ARRadioButton_CheckedChanged);
            // 
            // CallerTextBox
            // 
            this.CallerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CallerTextBox.Font = new System.Drawing.Font("Conthrax Sb", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallerTextBox.ForeColor = System.Drawing.Color.White;
            this.CallerTextBox.Location = new System.Drawing.Point(245, 42);
            this.CallerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CallerTextBox.Name = "CallerTextBox";
            this.CallerTextBox.Size = new System.Drawing.Size(347, 41);
            this.CallerTextBox.TabIndex = 3;
            this.CallerTextBox.TextChanged += new System.EventHandler(this.CallerTextBox_TextChanged);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Sea-Dog Italic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimerLabel.Location = new System.Drawing.Point(711, 25);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(194, 27);
            this.TimerLabel.TabIndex = 5;
            this.TimerLabel.Text = "00:00:00";
            // 
            // CallTimer
            // 
            this.CallTimer.Enabled = true;
            this.CallTimer.Tick += new System.EventHandler(this.CallTimer_Tick);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.Controls.Add(this.SaveButton);
            this.ButtonPanel.Controls.Add(this.ClearButton);
            this.ButtonPanel.Location = new System.Drawing.Point(20, 814);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(886, 72);
            this.ButtonPanel.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.SaveButton.Location = new System.Drawing.Point(739, 10);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(136, 59);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.ClearButton.Location = new System.Drawing.Point(25, 10);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(136, 59);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(920, 900);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.CallerTextBox);
            this.Controls.Add(this.StateCountyPanel);
            this.Controls.Add(this.ProbSolPanel);
            this.Controls.Add(this.CallerLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.ProbSolPanel.ResumeLayout(false);
            this.ProbSolPanel.PerformLayout();
            this.StateCountyPanel.ResumeLayout(false);
            this.StateCountyPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CallerLabel;
        private System.Windows.Forms.Panel ProbSolPanel;
        private System.Windows.Forms.RichTextBox ProblemRichTextBox;
        private System.Windows.Forms.RichTextBox SolutionRichTextBox;
        private System.Windows.Forms.Label SolutionLabel;
        private System.Windows.Forms.Label ProblemLabel;
        private System.Windows.Forms.Panel StateCountyPanel;
        private System.Windows.Forms.RadioButton VARadioButton;
        private System.Windows.Forms.RadioButton TNRadioButton;
        private System.Windows.Forms.RadioButton SCRadioButton;
        private System.Windows.Forms.RadioButton NCRadioButton;
        private System.Windows.Forms.RadioButton KYRadioButton;
        private System.Windows.Forms.RadioButton ARRadioButton;
        private System.Windows.Forms.ComboBox VAComboBox;
        private System.Windows.Forms.ComboBox TNComboBox;
        private System.Windows.Forms.ComboBox SCComboBox;
        private System.Windows.Forms.ComboBox NCComboBox;
        private System.Windows.Forms.ComboBox KYComboBox;
        private System.Windows.Forms.ComboBox ARComboBox;
        private System.Windows.Forms.TextBox CallerTextBox;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer CallTimer;
        private System.Windows.Forms.TextBox Batch_textBox;
        private System.Windows.Forms.TextBox Inst_textBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
    }
}
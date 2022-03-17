namespace WorkTool.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LogButton = new System.Windows.Forms.Button();
            this.SQLButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.GreetingLabel2 = new System.Windows.Forms.Label();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.ButtonsFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.DisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuPanel.Controls.Add(this.ButtonsFlowLayoutPanel);
            this.MenuPanel.Controls.Add(this.LogoPictureBox);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(226, 761);
            this.MenuPanel.TabIndex = 0;
            // 
            // ButtonsFlowLayoutPanel
            // 
            this.ButtonsFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonsFlowLayoutPanel.Controls.Add(this.LogButton);
            this.ButtonsFlowLayoutPanel.Controls.Add(this.SQLButton);
            this.ButtonsFlowLayoutPanel.Controls.Add(this.InfoButton);
            this.ButtonsFlowLayoutPanel.Controls.Add(this.SettingButton);
            this.ButtonsFlowLayoutPanel.Location = new System.Drawing.Point(0, 221);
            this.ButtonsFlowLayoutPanel.Name = "ButtonsFlowLayoutPanel";
            this.ButtonsFlowLayoutPanel.Size = new System.Drawing.Size(226, 451);
            this.ButtonsFlowLayoutPanel.TabIndex = 1;
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LogButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.Font = new System.Drawing.Font("Sea-Dog Italic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.LogButton.Location = new System.Drawing.Point(3, 3);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(223, 75);
            this.LogButton.TabIndex = 0;
            this.LogButton.Text = "Logging";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // SQLButton
            // 
            this.SQLButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SQLButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SQLButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.SQLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SQLButton.Font = new System.Drawing.Font("Sea-Dog Italic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.SQLButton.Location = new System.Drawing.Point(3, 84);
            this.SQLButton.Name = "SQLButton";
            this.SQLButton.Size = new System.Drawing.Size(223, 75);
            this.SQLButton.TabIndex = 0;
            this.SQLButton.Text = "SQL";
            this.SQLButton.UseVisualStyleBackColor = false;
            this.SQLButton.Click += new System.EventHandler(this.SQLButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.InfoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Sea-Dog Italic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.InfoButton.Location = new System.Drawing.Point(3, 165);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(223, 75);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SettingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("Sea-Dog Italic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.SettingButton.Location = new System.Drawing.Point(3, 246);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(223, 75);
            this.SettingButton.TabIndex = 0;
            this.SettingButton.Text = "Settings";
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoPictureBox.ErrorImage = null;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.ImageLocation = "";
            this.LogoPictureBox.Location = new System.Drawing.Point(35, 47);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(217, 215);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayPanel.Controls.Add(this.GreetingLabel2);
            this.DisplayPanel.Controls.Add(this.greetingsLabel);
            this.DisplayPanel.Location = new System.Drawing.Point(226, 0);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(836, 756);
            this.DisplayPanel.TabIndex = 1;
            // 
            // GreetingLabel2
            // 
            this.GreetingLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GreetingLabel2.AutoSize = true;
            this.GreetingLabel2.Font = new System.Drawing.Font("Airstrike", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingLabel2.ForeColor = System.Drawing.Color.White;
            this.GreetingLabel2.Location = new System.Drawing.Point(228, 180);
            this.GreetingLabel2.Name = "GreetingLabel2";
            this.GreetingLabel2.Size = new System.Drawing.Size(318, 25);
            this.GreetingLabel2.TabIndex = 0;
            this.GreetingLabel2.Text = "By: Shae Allen 2022";
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.greetingsLabel.AutoSize = true;
            this.greetingsLabel.Font = new System.Drawing.Font("Airstrike", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.greetingsLabel.Location = new System.Drawing.Point(131, 128);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(526, 35);
            this.greetingsLabel.TabIndex = 0;
            this.greetingsLabel.Text = "BIS Land Records Tool";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1065, 761);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BIS Land Records Tool";
            this.MenuPanel.ResumeLayout(false);
            this.ButtonsFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.DisplayPanel.ResumeLayout(false);
            this.DisplayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlowLayoutPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button SQLButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Label greetingsLabel;
        private System.Windows.Forms.Label GreetingLabel2;
    }
}


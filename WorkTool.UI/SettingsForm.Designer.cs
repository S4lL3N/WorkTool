namespace WorkTool.UI
{
    partial class SettingsForm
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
            this.LogPathLabel = new System.Windows.Forms.Label();
            this.Log_Path_Label = new System.Windows.Forms.Label();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.SaveLogButton = new System.Windows.Forms.Button();
            this.ChangeLogButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.JSONSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.JSONChangeButton = new System.Windows.Forms.Button();
            this.JSONTextBox = new System.Windows.Forms.TextBox();
            this.JSON_Path_Label = new System.Windows.Forms.Label();
            this.LogPanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogPathLabel
            // 
            this.LogPathLabel.AutoSize = true;
            this.LogPathLabel.Font = new System.Drawing.Font("Airstrike", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.LogPathLabel.Location = new System.Drawing.Point(3, 10);
            this.LogPathLabel.Name = "LogPathLabel";
            this.LogPathLabel.Size = new System.Drawing.Size(218, 21);
            this.LogPathLabel.TabIndex = 0;
            this.LogPathLabel.Text = "Path to Log File:";
            // 
            // Log_Path_Label
            // 
            this.Log_Path_Label.AutoSize = true;
            this.Log_Path_Label.Font = new System.Drawing.Font("Airstrike", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Path_Label.ForeColor = System.Drawing.Color.White;
            this.Log_Path_Label.Location = new System.Drawing.Point(3, 41);
            this.Log_Path_Label.Name = "Log_Path_Label";
            this.Log_Path_Label.Size = new System.Drawing.Size(72, 21);
            this.Log_Path_Label.TabIndex = 0;
            this.Log_Path_Label.Text = "Path";
            this.Log_Path_Label.Click += new System.EventHandler(this.Log_Path_Label_Click);
            // 
            // LogPanel
            // 
            this.LogPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogPanel.Controls.Add(this.SaveLogButton);
            this.LogPanel.Controls.Add(this.ChangeLogButton);
            this.LogPanel.Controls.Add(this.LogTextBox);
            this.LogPanel.Controls.Add(this.LogPathLabel);
            this.LogPanel.Controls.Add(this.Log_Path_Label);
            this.LogPanel.Location = new System.Drawing.Point(17, 12);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(789, 151);
            this.LogPanel.TabIndex = 1;
            // 
            // SaveLogButton
            // 
            this.SaveLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SaveLogButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.SaveLogButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SaveLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLogButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.SaveLogButton.Location = new System.Drawing.Point(677, 110);
            this.SaveLogButton.Name = "SaveLogButton";
            this.SaveLogButton.Size = new System.Drawing.Size(106, 29);
            this.SaveLogButton.TabIndex = 2;
            this.SaveLogButton.Text = "Save";
            this.SaveLogButton.UseVisualStyleBackColor = false;
            this.SaveLogButton.Click += new System.EventHandler(this.SaveLogButton_Click);
            // 
            // ChangeLogButton
            // 
            this.ChangeLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ChangeLogButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ChangeLogButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangeLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLogButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.ChangeLogButton.Location = new System.Drawing.Point(677, 75);
            this.ChangeLogButton.Name = "ChangeLogButton";
            this.ChangeLogButton.Size = new System.Drawing.Size(106, 29);
            this.ChangeLogButton.TabIndex = 2;
            this.ChangeLogButton.Text = "Change";
            this.ChangeLogButton.UseVisualStyleBackColor = false;
            this.ChangeLogButton.Click += new System.EventHandler(this.ChangeLogButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.Location = new System.Drawing.Point(7, 75);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(664, 30);
            this.LogTextBox.TabIndex = 1;
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged);
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPanel.Controls.Add(this.JSONSaveButton);
            this.DataPanel.Controls.Add(this.label1);
            this.DataPanel.Controls.Add(this.JSONChangeButton);
            this.DataPanel.Controls.Add(this.JSONTextBox);
            this.DataPanel.Controls.Add(this.JSON_Path_Label);
            this.DataPanel.Location = new System.Drawing.Point(17, 169);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(794, 151);
            this.DataPanel.TabIndex = 1;
            // 
            // JSONSaveButton
            // 
            this.JSONSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.JSONSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.JSONSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.JSONSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JSONSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JSONSaveButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JSONSaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.JSONSaveButton.Location = new System.Drawing.Point(683, 112);
            this.JSONSaveButton.Name = "JSONSaveButton";
            this.JSONSaveButton.Size = new System.Drawing.Size(106, 29);
            this.JSONSaveButton.TabIndex = 2;
            this.JSONSaveButton.Text = "Save";
            this.JSONSaveButton.UseVisualStyleBackColor = false;
            this.JSONSaveButton.Click += new System.EventHandler(this.JSONSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Airstrike", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to JSON Directory:";
            // 
            // JSONChangeButton
            // 
            this.JSONChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.JSONChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.JSONChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.JSONChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JSONChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JSONChangeButton.Font = new System.Drawing.Font("Airstrike", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JSONChangeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.JSONChangeButton.Location = new System.Drawing.Point(683, 77);
            this.JSONChangeButton.Name = "JSONChangeButton";
            this.JSONChangeButton.Size = new System.Drawing.Size(106, 29);
            this.JSONChangeButton.TabIndex = 2;
            this.JSONChangeButton.Text = "Change";
            this.JSONChangeButton.UseVisualStyleBackColor = false;
            this.JSONChangeButton.Click += new System.EventHandler(this.JSONChangeButton_Click);
            // 
            // JSONTextBox
            // 
            this.JSONTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JSONTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JSONTextBox.Location = new System.Drawing.Point(7, 77);
            this.JSONTextBox.Name = "JSONTextBox";
            this.JSONTextBox.Size = new System.Drawing.Size(669, 30);
            this.JSONTextBox.TabIndex = 1;
            this.JSONTextBox.TextChanged += new System.EventHandler(this.JSONTextBox_TextChanged);
            // 
            // JSON_Path_Label
            // 
            this.JSON_Path_Label.AutoSize = true;
            this.JSON_Path_Label.Font = new System.Drawing.Font("Airstrike", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JSON_Path_Label.ForeColor = System.Drawing.Color.White;
            this.JSON_Path_Label.Location = new System.Drawing.Point(3, 44);
            this.JSON_Path_Label.Name = "JSON_Path_Label";
            this.JSON_Path_Label.Size = new System.Drawing.Size(72, 21);
            this.JSON_Path_Label.TabIndex = 0;
            this.JSON_Path_Label.Text = "Path";
            this.JSON_Path_Label.Click += new System.EventHandler(this.JSON_Path_Label_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(818, 741);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.LogPanel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LogPathLabel;
        private System.Windows.Forms.Label Log_Path_Label;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label JSON_Path_Label;
        private System.Windows.Forms.Button SaveLogButton;
        private System.Windows.Forms.Button ChangeLogButton;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button JSONSaveButton;
        private System.Windows.Forms.Button JSONChangeButton;
        private System.Windows.Forms.TextBox JSONTextBox;
    }
}
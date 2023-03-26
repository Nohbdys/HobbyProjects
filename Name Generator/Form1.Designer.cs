namespace Name_Generator
{
    partial class Form1
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
            this.labelGenName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxRaces = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.listBoxGenNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPrevGenName = new System.Windows.Forms.Label();
            this.listBoxNamesUnsorted = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGenName
            // 
            this.labelGenName.AutoSize = true;
            this.labelGenName.Location = new System.Drawing.Point(406, 351);
            this.labelGenName.Name = "labelGenName";
            this.labelGenName.Size = new System.Drawing.Size(80, 13);
            this.labelGenName.TabIndex = 1;
            this.labelGenName.Text = "Press Generate";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generate Names";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxRaces
            // 
            this.comboBoxRaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRaces.FormattingEnabled = true;
            this.comboBoxRaces.Items.AddRange(new object[] {
            "Halfling",
            "Human"});
            this.comboBoxRaces.Location = new System.Drawing.Point(346, 222);
            this.comboBoxRaces.Name = "comboBoxRaces";
            this.comboBoxRaces.Size = new System.Drawing.Size(151, 21);
            this.comboBoxRaces.TabIndex = 3;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(346, 249);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(151, 21);
            this.comboBoxGender.TabIndex = 4;
            // 
            // listBoxGenNames
            // 
            this.listBoxGenNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGenNames.FormattingEnabled = true;
            this.listBoxGenNames.Location = new System.Drawing.Point(749, 18);
            this.listBoxGenNames.Name = "listBoxGenNames";
            this.listBoxGenNames.Size = new System.Drawing.Size(266, 407);
            this.listBoxGenNames.Sorted = true;
            this.listBoxGenNames.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Newest Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Previous Name:";
            // 
            // labelPrevGenName
            // 
            this.labelPrevGenName.AutoSize = true;
            this.labelPrevGenName.Location = new System.Drawing.Point(406, 387);
            this.labelPrevGenName.Name = "labelPrevGenName";
            this.labelPrevGenName.Size = new System.Drawing.Size(80, 13);
            this.labelPrevGenName.TabIndex = 9;
            this.labelPrevGenName.Text = "Press Generate";
            // 
            // listBoxNamesUnsorted
            // 
            this.listBoxNamesUnsorted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxNamesUnsorted.FormattingEnabled = true;
            this.listBoxNamesUnsorted.Location = new System.Drawing.Point(12, 12);
            this.listBoxNamesUnsorted.Name = "listBoxNamesUnsorted";
            this.listBoxNamesUnsorted.Size = new System.Drawing.Size(266, 407);
            this.listBoxNamesUnsorted.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Race:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gender:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(343, 287);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 446);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxNamesUnsorted);
            this.Controls.Add(this.labelPrevGenName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGenNames);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.comboBoxRaces);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelGenName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxRaces;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ListBox listBoxGenNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrevGenName;
        private System.Windows.Forms.ListBox listBoxNamesUnsorted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelError;
    }
}


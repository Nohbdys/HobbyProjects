namespace CycleProject
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
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonCycle = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPrevious = new System.Windows.Forms.Label();
            this.labelNext = new System.Windows.Forms.Label();
            this.labelCycle = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.textBoxFolderName = new System.Windows.Forms.TextBox();
            this.buttonUseFolder = new System.Windows.Forms.Button();
            this.textBoxMinGifTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPrevious.Location = new System.Drawing.Point(1016, 261);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonCycle
            // 
            this.buttonCycle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCycle.Location = new System.Drawing.Point(1098, 373);
            this.buttonCycle.Name = "buttonCycle";
            this.buttonCycle.Size = new System.Drawing.Size(75, 23);
            this.buttonCycle.TabIndex = 1;
            this.buttonCycle.Text = "Cycle";
            this.buttonCycle.UseVisualStyleBackColor = true;
            this.buttonCycle.Click += new System.EventHandler(this.buttonCycle_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonNext.Location = new System.Drawing.Point(1097, 261);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 764);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelPrevious
            // 
            this.labelPrevious.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrevious.AutoSize = true;
            this.labelPrevious.Location = new System.Drawing.Point(1037, 287);
            this.labelPrevious.Name = "labelPrevious";
            this.labelPrevious.Size = new System.Drawing.Size(35, 13);
            this.labelPrevious.TabIndex = 4;
            this.labelPrevious.Text = "label1";
            // 
            // labelNext
            // 
            this.labelNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNext.AutoSize = true;
            this.labelNext.Location = new System.Drawing.Point(1119, 287);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(35, 13);
            this.labelNext.TabIndex = 5;
            this.labelNext.Text = "label2";
            // 
            // labelCycle
            // 
            this.labelCycle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCycle.AutoSize = true;
            this.labelCycle.Location = new System.Drawing.Point(1119, 399);
            this.labelCycle.Name = "labelCycle";
            this.labelCycle.Size = new System.Drawing.Size(35, 13);
            this.labelCycle.TabIndex = 6;
            this.labelCycle.Text = "label3";
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxDelay.Location = new System.Drawing.Point(1041, 375);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(51, 20);
            this.textBoxDelay.TabIndex = 7;
            // 
            // buttonFolder
            // 
            this.buttonFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonFolder.Location = new System.Drawing.Point(1056, 23);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(120, 23);
            this.buttonFolder.TabIndex = 8;
            this.buttonFolder.Text = "Choose Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(1098, 74);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(79, 17);
            this.checkBoxRandom.TabIndex = 9;
            this.checkBoxRandom.Text = "Randomize";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            // 
            // textBoxFolderName
            // 
            this.textBoxFolderName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxFolderName.Location = new System.Drawing.Point(1077, 149);
            this.textBoxFolderName.Name = "textBoxFolderName";
            this.textBoxFolderName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFolderName.TabIndex = 10;
            // 
            // buttonUseFolder
            // 
            this.buttonUseFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUseFolder.Location = new System.Drawing.Point(1088, 175);
            this.buttonUseFolder.Name = "buttonUseFolder";
            this.buttonUseFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonUseFolder.TabIndex = 11;
            this.buttonUseFolder.Text = "Use Folder";
            this.buttonUseFolder.UseVisualStyleBackColor = true;
            this.buttonUseFolder.Click += new System.EventHandler(this.buttonUseFolder_Click);
            // 
            // textBoxMinGifTime
            // 
            this.textBoxMinGifTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxMinGifTime.Location = new System.Drawing.Point(1016, 452);
            this.textBoxMinGifTime.Name = "textBoxMinGifTime";
            this.textBoxMinGifTime.Size = new System.Drawing.Size(72, 20);
            this.textBoxMinGifTime.TabIndex = 12;
            this.textBoxMinGifTime.TextChanged += new System.EventHandler(this.textBoxMinGifTime_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1094, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Minimum Gif Time";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(-23, -46);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1033, 810);
            this.webBrowser1.TabIndex = 14;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser2.Location = new System.Drawing.Point(-23, -46);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(1033, 810);
            this.webBrowser2.TabIndex = 15;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMinGifTime);
            this.Controls.Add(this.buttonUseFolder);
            this.Controls.Add(this.textBoxFolderName);
            this.Controls.Add(this.checkBoxRandom);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.textBoxDelay);
            this.Controls.Add(this.labelCycle);
            this.Controls.Add(this.labelNext);
            this.Controls.Add(this.labelPrevious);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonCycle);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.webBrowser2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonCycle;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPrevious;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.Label labelCycle;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.TextBox textBoxFolderName;
        private System.Windows.Forms.Button buttonUseFolder;
        private System.Windows.Forms.TextBox textBoxMinGifTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}


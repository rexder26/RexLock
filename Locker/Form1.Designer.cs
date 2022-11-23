namespace Locker
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
            this.btnlock = new System.Windows.Forms.Button();
            this.btnunlock = new System.Windows.Forms.Button();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlock
            // 
            this.btnlock.Location = new System.Drawing.Point(102, 76);
            this.btnlock.Name = "btnlock";
            this.btnlock.Size = new System.Drawing.Size(75, 23);
            this.btnlock.TabIndex = 0;
            this.btnlock.Text = "Lock";
            this.btnlock.UseVisualStyleBackColor = true;
            this.btnlock.Click += new System.EventHandler(this.btnlock_Click_1);
            // 
            // btnunlock
            // 
            this.btnunlock.Location = new System.Drawing.Point(183, 76);
            this.btnunlock.Name = "btnunlock";
            this.btnunlock.Size = new System.Drawing.Size(75, 23);
            this.btnunlock.TabIndex = 1;
            this.btnunlock.Text = "Unlock";
            this.btnunlock.UseVisualStyleBackColor = true;
            this.btnunlock.Click += new System.EventHandler(this.btnunlock_Click_1);
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(280, 28);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(39, 23);
            this.btnbrowser.TabIndex = 2;
            this.btnbrowser.Text = "...";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(12, 28);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(262, 20);
            this.txtpath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter The Folder Path and enter lock ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(264, 76);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 111);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btnbrowser);
            this.Controls.Add(this.btnunlock);
            this.Controls.Add(this.btnlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Folder Locker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlock;
        private System.Windows.Forms.Button btnunlock;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
    }
}


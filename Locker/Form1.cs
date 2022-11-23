using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace Locker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnunlock_Click_1(object sender, EventArgs e)
        {
            if (txtpath.Text.Length > 0)
            {
                try
                {
                    string folderPath = txtpath.Text;
                    string adminUserName = Environment.UserName;// getting your adminUserName
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.RemoveAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    MessageBox.Show("Unlocked");
                }
                catch
                {
                }
            }
        }

        private void btnlock_Click_1(object sender, EventArgs e)
        {

           
            if (txtpath.Text.Length > 0)
            {
                try
                {
                    string folderPath = txtpath.Text;
                    string adminUserName = Environment.UserName;// getting your adminUserName
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    MessageBox.Show("Locked");
                }

                catch
                {
                }
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }
}

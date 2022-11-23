using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Locker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "nathan")
            { 
               Form1 f1 =new Form1();
               Form2 f2 =new Form2();
                this.Hide();
               

               
            }
        }
    }
}

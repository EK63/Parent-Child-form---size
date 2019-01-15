using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM1
{
    public partial class Form1 : Form
    {
        //
        // Static code START
        //
            public static int mheight;
            public static Form1 form1;
            public Form1()
            {
                    InitializeComponent();
                // assign the current object to form1
                    form1 = this;
            }

            private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
            {
                    Form2 newMDIChild = new Form2();
                // Set the Parent Form of the Child window.  
                    newMDIChild.MdiParent = this;
                // Display the new form.  
                    newMDIChild.Show();
            }  

            private void Form1_Load(object sender, EventArgs e)
            {
                // get menustrip's height
                    mheight = this.menuStrip1.Height;
            }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       
        //
        // Static code END
        //
    }
}

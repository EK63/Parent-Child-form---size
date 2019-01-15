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
    public partial class Form2 : Form
    {
        //
        // Size code START
        //
            private void Form2_Load(object sender, EventArgs e)
            {
                string message6 = "Form 2 loaded";
                    MessageBox.Show(message6);

                // Form2 size start
                    this.WindowState = FormWindowState.Normal;
                    Size NewSize = new Size(Form1.form1.ClientRectangle.Width, Form1.form1.ClientRectangle.Height);
                //Modifiy the size so any toolbars & taskbar can be easily accessed.
                    NewSize.Height -= 75;
                // minus mheight
                    NewSize.Height -= Form1.mheight;
                    NewSize.Width -= 12;
                    this.Size = NewSize;
                //Point NewLoc = Screen.FromControl(this).WorkingArea.Location;
                    Point NewLoc = new Point();
                //Modifiy the location so any toolbars & taskbar can be easily accessed.
                    NewLoc.X += 12;
                    NewLoc.Y += 75;
                    this.Location = NewLoc;
                //
                    this.MinimumSize = this.Size;
                    this.MaximumSize = this.MinimumSize;
                // end
            }
        //
        // Size code END
        //
    }
}

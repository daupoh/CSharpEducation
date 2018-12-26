using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animationInWinForm
{
    public partial class Form1 : Form
    {
        bool started = false;
        int red, green, blue;
        public Form1()
        {
            InitializeComponent();
            red = this.BackColor.R;
            green = this.BackColor.G;
            blue = this.BackColor.B;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            started = !started;
           
            string buttonText = "";
            if (started)
            {
                buttonText = "Stop!";
            }
            else
            {
                buttonText = "Go!";
                this.BackColor = Color.FromArgb(red, green, blue);
                
            }
            btnGo.Text = buttonText;
            while (started)
            {
                for (int c = 0; c < 253 && started; c++)
                {
                    this.BackColor = Color.FromArgb(c, 253 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
                for (int c = 255; c > 0 && started; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }
        }
    }
}

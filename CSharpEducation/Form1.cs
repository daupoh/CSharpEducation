using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEducation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoChange_Click(object sender, EventArgs e)
        {
            if (cbxCheck.Checked==true)
            {
                if (lblChangeText.Text=="Right")
                {
                    lblChangeText.Text = "Left";
                    lblChangeText.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    lblChangeText.Text = "Right";
                    lblChangeText.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                lblChangeText.Text = "Text changing is disabled";
                lblChangeText.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}

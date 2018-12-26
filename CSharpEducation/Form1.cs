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
        CLabelBouncer[] m_apLblBnc = new CLabelBouncer[3];
        public Form1()
        {
            InitializeComponent();
        }
        private void bounce(uint index, Label label)
        {
            if (m_apLblBnc[index] == null)
            {
                m_apLblBnc[index] = new CLabelBouncer();

                m_apLblBnc[index].MyLabel = label;
            }
            else
            {
                m_apLblBnc[index] = null;
            }
        }
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (m_apLblBnc[i]!=null)
                {
                    m_apLblBnc[i].Move();
                }
            }
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            bounce(0, lblFirst);
        }

        private void btnMoveSecond_Click(object sender, EventArgs e)
        {
            bounce(1, lblSecond);
        }

        private void btnMoveThird_Click(object sender, EventArgs e)
        {
            bounce(2, lblThird);
        }
    }
}

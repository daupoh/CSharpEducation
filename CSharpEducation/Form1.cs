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
    public partial class fmPartyCalculator : Form
    {
        CDinnerParty m_rDinnerParty = new CDinnerParty();
        public fmPartyCalculator()
        {
            InitializeComponent();
        }
        private void UpdateCost()
        {
            decimal cost = m_rDinnerParty.CalculateCost(numCountOfPerson.Value);
            tbxCostResult.Text = cost.ToString()+"$";
        }
        private void cbxIsFancyDecor_CheckedChanged(object sender, EventArgs e)
        {
            m_rDinnerParty.calculateCostOfDecorations(cbxIsFancyDecor.Checked);
            UpdateCost();
        }

        private void cbxIsHealthyDrink_CheckedChanged(object sender, EventArgs e)
        {
            m_rDinnerParty.setHealthyOption(cbxIsHealthyDrink.Checked);
            UpdateCost();
        }

        private void numCountOfPerson_ValueChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }
    }
}

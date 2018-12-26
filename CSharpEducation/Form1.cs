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
    public partial class fmMachineDisplay : Form
    {
        Random random = new Random();
        CStats stats = new CStats();
        public fmMachineDisplay()
        {
            InitializeComponent();
        }

        private void tmrAdder_Tick(object sender, EventArgs e)
        {
            lbxPrints.Items.Add((Keys)random.Next(65, 90));
            if (lbxPrints.Items.Count>7)
            {
                lbxPrints.Items.Clear();
                lbxPrints.Items.Add("Игра окончена!");
                tmrAdder.Stop();
            }
        }
        private void restartGame()
        {
            stats = new CStats();
            lbxPrints.Items.Clear();
            tmrAdder.Interval = 800;
            tlLblCorrect.Text = "Correct: " + 0;
            tlLblMissed.Text = "Missed: " + 0;
            tlLblTotal.Text = "Total: " + 0;
            tlLblAccuracy.Text = "Accuracy: " + 0 + "%";        
        tmrAdder.Enabled = true;
            tlPrgBarDifficulty.Value = 0;
            
        }
        private void fmMachineDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (lbxPrints.Items.Contains("Игра окончена!"))
            {
                restartGame();
            }
            if (lbxPrints.Items.Contains(e.KeyCode))
            {
                lbxPrints.Items.Remove(e.KeyCode);
                lbxPrints.Refresh();
                if (tmrAdder.Interval > 400)
                {
                    tmrAdder.Interval -= 10;
                }
                if (tmrAdder.Interval > 250)
                {
                    tmrAdder.Interval -= 7;
                }
                if (tmrAdder.Interval > 100)
                {
                    tmrAdder.Interval -= 2;
                }
                tlPrgBarDifficulty.Value = 800 - tmrAdder.Interval;
                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }
            tlLblCorrect.Text = "Correct: " + stats.Correct;
            tlLblMissed.Text = "Missed: " + stats.Missed;
            tlLblTotal.Text = "Total: " + stats.Total;
            tlLblAccuracy.Text = "Accuracy: " + stats.Accuracy + "%";
        }
    }
}

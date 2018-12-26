namespace CSharpEducation
{
    partial class fmMachineDisplay
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbxPrints = new System.Windows.Forms.ListBox();
            this.tmrAdder = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlLblCorrect = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlLblMissed = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlLblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlLblAccuracy = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlLblDifficulty = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlPrgBarDifficulty = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxPrints
            // 
            this.lbxPrints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxPrints.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxPrints.FormattingEnabled = true;
            this.lbxPrints.ItemHeight = 108;
            this.lbxPrints.Location = new System.Drawing.Point(0, 0);
            this.lbxPrints.MultiColumn = true;
            this.lbxPrints.Name = "lbxPrints";
            this.lbxPrints.Size = new System.Drawing.Size(856, 132);
            this.lbxPrints.TabIndex = 0;
            // 
            // tmrAdder
            // 
            this.tmrAdder.Enabled = true;
            this.tmrAdder.Interval = 800;
            this.tmrAdder.Tick += new System.EventHandler(this.tmrAdder_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlLblCorrect,
            this.tlLblMissed,
            this.tlLblTotal,
            this.tlLblAccuracy,
            this.tlLblDifficulty,
            this.tlPrgBarDifficulty});
            this.statusStrip1.Location = new System.Drawing.Point(0, 110);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlLblCorrect
            // 
            this.tlLblCorrect.Name = "tlLblCorrect";
            this.tlLblCorrect.Size = new System.Drawing.Size(58, 17);
            this.tlLblCorrect.Text = "Correct: 0";
            // 
            // tlLblMissed
            // 
            this.tlLblMissed.Name = "tlLblMissed";
            this.tlLblMissed.Size = new System.Drawing.Size(56, 17);
            this.tlLblMissed.Text = "Missed: 0";
            // 
            // tlLblTotal
            // 
            this.tlLblTotal.Name = "tlLblTotal";
            this.tlLblTotal.Size = new System.Drawing.Size(46, 17);
            this.tlLblTotal.Text = "Total: 0";
            // 
            // tlLblAccuracy
            // 
            this.tlLblAccuracy.Name = "tlLblAccuracy";
            this.tlLblAccuracy.Size = new System.Drawing.Size(78, 17);
            this.tlLblAccuracy.Text = "Accuracy: 0%";
            // 
            // tlLblDifficulty
            // 
            this.tlLblDifficulty.Name = "tlLblDifficulty";
            this.tlLblDifficulty.Size = new System.Drawing.Size(501, 17);
            this.tlLblDifficulty.Spring = true;
            this.tlLblDifficulty.Text = "Difficulty";
            this.tlLblDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlPrgBarDifficulty
            // 
            this.tlPrgBarDifficulty.Maximum = 701;
            this.tlPrgBarDifficulty.Name = "tlPrgBarDifficulty";
            this.tlPrgBarDifficulty.Size = new System.Drawing.Size(100, 16);
            // 
            // fmMachineDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 132);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbxPrints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMachineDisplay";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmMachineDisplay_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPrints;
        private System.Windows.Forms.Timer tmrAdder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlLblCorrect;
        private System.Windows.Forms.ToolStripStatusLabel tlLblMissed;
        private System.Windows.Forms.ToolStripStatusLabel tlLblTotal;
        private System.Windows.Forms.ToolStripStatusLabel tlLblAccuracy;
        private System.Windows.Forms.ToolStripStatusLabel tlLblDifficulty;
        private System.Windows.Forms.ToolStripProgressBar tlPrgBarDifficulty;
    }
}


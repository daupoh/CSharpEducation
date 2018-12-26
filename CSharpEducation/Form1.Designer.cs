namespace CSharpEducation
{
    partial class fmPartyCalculator
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
            this.numCountOfPerson = new System.Windows.Forms.NumericUpDown();
            this.cbxIsFancyDecor = new System.Windows.Forms.CheckBox();
            this.cbxIsHealthyDrink = new System.Windows.Forms.CheckBox();
            this.tbxCostResult = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxTotalResult = new System.Windows.Forms.TextBox();
            this.btnAddToTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCountOfPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // numCountOfPerson
            // 
            this.numCountOfPerson.Location = new System.Drawing.Point(12, 12);
            this.numCountOfPerson.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCountOfPerson.Name = "numCountOfPerson";
            this.numCountOfPerson.Size = new System.Drawing.Size(146, 20);
            this.numCountOfPerson.TabIndex = 0;
            this.numCountOfPerson.ValueChanged += new System.EventHandler(this.numCountOfPerson_ValueChanged);
            // 
            // cbxIsFancyDecor
            // 
            this.cbxIsFancyDecor.AutoSize = true;
            this.cbxIsFancyDecor.Location = new System.Drawing.Point(12, 38);
            this.cbxIsFancyDecor.Name = "cbxIsFancyDecor";
            this.cbxIsFancyDecor.Size = new System.Drawing.Size(131, 17);
            this.cbxIsFancyDecor.TabIndex = 1;
            this.cbxIsFancyDecor.Text = "Особое оформление";
            this.cbxIsFancyDecor.UseVisualStyleBackColor = true;
            this.cbxIsFancyDecor.CheckedChanged += new System.EventHandler(this.cbxIsFancyDecor_CheckedChanged);
            // 
            // cbxIsHealthyDrink
            // 
            this.cbxIsHealthyDrink.AutoSize = true;
            this.cbxIsHealthyDrink.Location = new System.Drawing.Point(12, 61);
            this.cbxIsHealthyDrink.Name = "cbxIsHealthyDrink";
            this.cbxIsHealthyDrink.Size = new System.Drawing.Size(131, 17);
            this.cbxIsHealthyDrink.TabIndex = 2;
            this.cbxIsHealthyDrink.Text = "\"Здоровые\" напитки";
            this.cbxIsHealthyDrink.UseVisualStyleBackColor = true;
            this.cbxIsHealthyDrink.CheckedChanged += new System.EventHandler(this.cbxIsHealthyDrink_CheckedChanged);
            // 
            // tbxCostResult
            // 
            this.tbxCostResult.Location = new System.Drawing.Point(58, 84);
            this.tbxCostResult.Name = "tbxCostResult";
            this.tbxCostResult.ReadOnly = true;
            this.tbxCostResult.Size = new System.Drawing.Size(100, 20);
            this.tbxCostResult.TabIndex = 3;
            this.tbxCostResult.Text = "0$";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(9, 87);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(36, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Цена:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 142);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Итого:";
            // 
            // tbxTotalResult
            // 
            this.tbxTotalResult.Location = new System.Drawing.Point(58, 139);
            this.tbxTotalResult.Name = "tbxTotalResult";
            this.tbxTotalResult.ReadOnly = true;
            this.tbxTotalResult.Size = new System.Drawing.Size(100, 20);
            this.tbxTotalResult.TabIndex = 6;
            this.tbxTotalResult.Text = "0$";
            // 
            // btnAddToTotal
            // 
            this.btnAddToTotal.Location = new System.Drawing.Point(12, 110);
            this.btnAddToTotal.Name = "btnAddToTotal";
            this.btnAddToTotal.Size = new System.Drawing.Size(146, 23);
            this.btnAddToTotal.TabIndex = 7;
            this.btnAddToTotal.Text = "Прибавить";
            this.btnAddToTotal.UseVisualStyleBackColor = true;
            // 
            // fmPartyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAddToTotal);
            this.Controls.Add(this.tbxTotalResult);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.tbxCostResult);
            this.Controls.Add(this.cbxIsHealthyDrink);
            this.Controls.Add(this.cbxIsFancyDecor);
            this.Controls.Add(this.numCountOfPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmPartyCalculator";
            this.Text = "Калькулятор вечеринки";
            ((System.ComponentModel.ISupportInitialize)(this.numCountOfPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numCountOfPerson;
        private System.Windows.Forms.CheckBox cbxIsFancyDecor;
        private System.Windows.Forms.CheckBox cbxIsHealthyDrink;
        private System.Windows.Forms.TextBox tbxCostResult;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbxTotalResult;
        private System.Windows.Forms.Button btnAddToTotal;
    }
}


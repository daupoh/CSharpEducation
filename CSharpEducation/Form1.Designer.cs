namespace CSharpEducation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDoChange = new System.Windows.Forms.Button();
            this.cbxCheck = new System.Windows.Forms.CheckBox();
            this.lblChangeText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoChange
            // 
            this.btnDoChange.Location = new System.Drawing.Point(12, 12);
            this.btnDoChange.Name = "btnDoChange";
            this.btnDoChange.Size = new System.Drawing.Size(182, 23);
            this.btnDoChange.TabIndex = 0;
            this.btnDoChange.Text = "Change the label if checked";
            this.btnDoChange.UseVisualStyleBackColor = true;
            this.btnDoChange.Click += new System.EventHandler(this.btnDoChange_Click);
            // 
            // cbxCheck
            // 
            this.cbxCheck.AutoSize = true;
            this.cbxCheck.Checked = true;
            this.cbxCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCheck.Location = new System.Drawing.Point(210, 16);
            this.cbxCheck.Name = "cbxCheck";
            this.cbxCheck.Size = new System.Drawing.Size(131, 17);
            this.cbxCheck.TabIndex = 1;
            this.cbxCheck.Text = "Enable label changing";
            this.cbxCheck.UseVisualStyleBackColor = true;
            // 
            // lblChangeText
            // 
            this.lblChangeText.Location = new System.Drawing.Point(12, 53);
            this.lblChangeText.Name = "lblChangeText";
            this.lblChangeText.Size = new System.Drawing.Size(329, 23);
            this.lblChangeText.TabIndex = 2;
            this.lblChangeText.Text = "Press the button to change my text";
            this.lblChangeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 92);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblChangeText);
            this.Controls.Add(this.cbxCheck);
            this.Controls.Add(this.btnDoChange);
            this.Name = "Form1";
            this.Text = "My desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoChange;
        private System.Windows.Forms.CheckBox cbxCheck;
        private System.Windows.Forms.Label lblChangeText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


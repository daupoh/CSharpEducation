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
            this.cmbxLocations = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnGoOutside = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbxLocations
            // 
            this.cmbxLocations.FormattingEnabled = true;
            this.cmbxLocations.Location = new System.Drawing.Point(176, 207);
            this.cmbxLocations.Name = "cmbxLocations";
            this.cmbxLocations.Size = new System.Drawing.Size(197, 21);
            this.cmbxLocations.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 207);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(139, 21);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Перейти в :";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnGoOutside
            // 
            this.btnGoOutside.Location = new System.Drawing.Point(12, 234);
            this.btnGoOutside.Name = "btnGoOutside";
            this.btnGoOutside.Size = new System.Drawing.Size(361, 23);
            this.btnGoOutside.TabIndex = 2;
            this.btnGoOutside.Text = "Пройти через дверь";
            this.btnGoOutside.UseVisualStyleBackColor = true;
            this.btnGoOutside.Click += new System.EventHandler(this.btnGoOutside_Click);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(12, 12);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.Size = new System.Drawing.Size(361, 189);
            this.tbxDescription.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 269);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.btnGoOutside);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmbxLocations);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxLocations;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnGoOutside;
        private System.Windows.Forms.TextBox tbxDescription;
    }
}


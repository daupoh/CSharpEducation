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
            this.components = new System.ComponentModel.Container();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnMoveSecond = new System.Windows.Forms.Button();
            this.btnMoveThird = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(12, 9);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(90, 13);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Первая надпись";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(12, 34);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(88, 13);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Вторая надпись";
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.Location = new System.Drawing.Point(12, 61);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(88, 13);
            this.lblThird.TabIndex = 2;
            this.lblThird.Text = "Третья надпись";
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Location = new System.Drawing.Point(15, 103);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(104, 33);
            this.btnMoveFirst.TabIndex = 3;
            this.btnMoveFirst.Text = "Двигай первую";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnMoveSecond
            // 
            this.btnMoveSecond.Location = new System.Drawing.Point(15, 142);
            this.btnMoveSecond.Name = "btnMoveSecond";
            this.btnMoveSecond.Size = new System.Drawing.Size(104, 33);
            this.btnMoveSecond.TabIndex = 4;
            this.btnMoveSecond.Text = "Двигай вторую";
            this.btnMoveSecond.UseVisualStyleBackColor = true;
            this.btnMoveSecond.Click += new System.EventHandler(this.btnMoveSecond_Click);
            // 
            // btnMoveThird
            // 
            this.btnMoveThird.Location = new System.Drawing.Point(15, 181);
            this.btnMoveThird.Name = "btnMoveThird";
            this.btnMoveThird.Size = new System.Drawing.Size(104, 33);
            this.btnMoveThird.TabIndex = 5;
            this.btnMoveThird.Text = "Двигай третью";
            this.btnMoveThird.UseVisualStyleBackColor = true;
            this.btnMoveThird.Click += new System.EventHandler(this.btnMoveThird_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMoveThird);
            this.Controls.Add(this.btnMoveSecond);
            this.Controls.Add(this.btnMoveFirst);
            this.Controls.Add(this.lblThird);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnMoveSecond;
        private System.Windows.Forms.Button btnMoveThird;
        private System.Windows.Forms.Timer tmrTime;
    }
}


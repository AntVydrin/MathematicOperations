namespace TestLU
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBox_a11 = new System.Windows.Forms.TextBox();
            this.textBox_a21 = new System.Windows.Forms.TextBox();
            this.textBox_a12 = new System.Windows.Forms.TextBox();
            this.textBox_a22 = new System.Windows.Forms.TextBox();
            this.textBox_u1 = new System.Windows.Forms.TextBox();
            this.textBox_u2 = new System.Windows.Forms.TextBox();
            this.label_Answer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(130, 128);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Расчёт";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBox_a11
            // 
            this.textBox_a11.Location = new System.Drawing.Point(46, 49);
            this.textBox_a11.Name = "textBox_a11";
            this.textBox_a11.Size = new System.Drawing.Size(43, 20);
            this.textBox_a11.TabIndex = 1;
            this.textBox_a11.Text = "3";
            // 
            // textBox_a21
            // 
            this.textBox_a21.Location = new System.Drawing.Point(46, 75);
            this.textBox_a21.Name = "textBox_a21";
            this.textBox_a21.Size = new System.Drawing.Size(43, 20);
            this.textBox_a21.TabIndex = 2;
            this.textBox_a21.Text = "2";
            // 
            // textBox_a12
            // 
            this.textBox_a12.Location = new System.Drawing.Point(115, 49);
            this.textBox_a12.Name = "textBox_a12";
            this.textBox_a12.Size = new System.Drawing.Size(43, 20);
            this.textBox_a12.TabIndex = 1;
            this.textBox_a12.Text = "1";
            // 
            // textBox_a22
            // 
            this.textBox_a22.Location = new System.Drawing.Point(115, 75);
            this.textBox_a22.Name = "textBox_a22";
            this.textBox_a22.Size = new System.Drawing.Size(43, 20);
            this.textBox_a22.TabIndex = 2;
            this.textBox_a22.Text = "1";
            // 
            // textBox_u1
            // 
            this.textBox_u1.Location = new System.Drawing.Point(235, 49);
            this.textBox_u1.Name = "textBox_u1";
            this.textBox_u1.Size = new System.Drawing.Size(36, 20);
            this.textBox_u1.TabIndex = 1;
            this.textBox_u1.Text = "0.5";
            // 
            // textBox_u2
            // 
            this.textBox_u2.Location = new System.Drawing.Point(235, 75);
            this.textBox_u2.Name = "textBox_u2";
            this.textBox_u2.Size = new System.Drawing.Size(36, 20);
            this.textBox_u2.TabIndex = 2;
            this.textBox_u2.Text = "0.2";
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Answer.Location = new System.Drawing.Point(296, 59);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(21, 24);
            this.label_Answer.TabIndex = 3;
            this.label_Answer.Text = "=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.textBox_u2);
            this.Controls.Add(this.textBox_a22);
            this.Controls.Add(this.textBox_a21);
            this.Controls.Add(this.textBox_u1);
            this.Controls.Add(this.textBox_a12);
            this.Controls.Add(this.textBox_a11);
            this.Controls.Add(this.buttonCalc);
            this.Name = "Form1";
            this.Text = "Тест решения системы линейных уравнений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBox_a11;
        private System.Windows.Forms.TextBox textBox_a21;
        private System.Windows.Forms.TextBox textBox_a12;
        private System.Windows.Forms.TextBox textBox_a22;
        private System.Windows.Forms.TextBox textBox_u1;
        private System.Windows.Forms.TextBox textBox_u2;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.Button button1;
    }
}


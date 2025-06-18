namespace IntegralTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_integr_trap = new System.Windows.Forms.Button();
            this.label_integr_trap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button_integr_trap
            // 
            this.button_integr_trap.Location = new System.Drawing.Point(292, 273);
            this.button_integr_trap.Name = "button_integr_trap";
            this.button_integr_trap.Size = new System.Drawing.Size(117, 25);
            this.button_integr_trap.TabIndex = 2;
            this.button_integr_trap.Text = "Метод трапеций";
            this.button_integr_trap.UseVisualStyleBackColor = true;
            this.button_integr_trap.Click += new System.EventHandler(this.button_integr_trap_Click);
            // 
            // label_integr_trap
            // 
            this.label_integr_trap.AutoSize = true;
            this.label_integr_trap.Location = new System.Drawing.Point(307, 313);
            this.label_integr_trap.Name = "label_integr_trap";
            this.label_integr_trap.Size = new System.Drawing.Size(35, 13);
            this.label_integr_trap.TabIndex = 3;
            this.label_integr_trap.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 510);
            this.Controls.Add(this.label_integr_trap);
            this.Controls.Add(this.button_integr_trap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_integr_trap;
        private System.Windows.Forms.Label label_integr_trap;
    }
}


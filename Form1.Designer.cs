namespace norm
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxChrome = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxFirefox = new System.Windows.Forms.CheckBox();
            this.checkBoxOpera = new System.Windows.Forms.CheckBox();
            this.checkBoxOperaGX = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browsers";
            // 
            // checkBoxChrome
            // 
            this.checkBoxChrome.AutoSize = true;
            this.checkBoxChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkBoxChrome.Location = new System.Drawing.Point(38, 83);
            this.checkBoxChrome.Name = "checkBoxChrome";
            this.checkBoxChrome.Size = new System.Drawing.Size(213, 33);
            this.checkBoxChrome.TabIndex = 1;
            this.checkBoxChrome.Text = "Google Chrome";
            this.checkBoxChrome.UseVisualStyleBackColor = true;
            this.checkBoxChrome.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(281, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxFirefox
            // 
            this.checkBoxFirefox.AutoSize = true;
            this.checkBoxFirefox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkBoxFirefox.Location = new System.Drawing.Point(38, 122);
            this.checkBoxFirefox.Name = "checkBoxFirefox";
            this.checkBoxFirefox.Size = new System.Drawing.Size(198, 33);
            this.checkBoxFirefox.TabIndex = 3;
            this.checkBoxFirefox.Text = "Mozilla Firefox";
            this.checkBoxFirefox.UseVisualStyleBackColor = true;
            this.checkBoxFirefox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxOpera
            // 
            this.checkBoxOpera.AutoSize = true;
            this.checkBoxOpera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkBoxOpera.Location = new System.Drawing.Point(38, 161);
            this.checkBoxOpera.Name = "checkBoxOpera";
            this.checkBoxOpera.Size = new System.Drawing.Size(104, 33);
            this.checkBoxOpera.TabIndex = 4;
            this.checkBoxOpera.Text = "Opera";
            this.checkBoxOpera.UseVisualStyleBackColor = true;
            // 
            // checkBoxOperaGX
            // 
            this.checkBoxOperaGX.AutoSize = true;
            this.checkBoxOperaGX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkBoxOperaGX.Location = new System.Drawing.Point(38, 200);
            this.checkBoxOperaGX.Name = "checkBoxOperaGX";
            this.checkBoxOperaGX.Size = new System.Drawing.Size(147, 33);
            this.checkBoxOperaGX.TabIndex = 5;
            this.checkBoxOperaGX.Text = "Opera GX";
            this.checkBoxOperaGX.UseVisualStyleBackColor = true;
            this.checkBoxOperaGX.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar1.Location = new System.Drawing.Point(12, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(783, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Статус: Ожидание";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBoxOperaGX);
            this.Controls.Add(this.checkBoxOpera);
            this.Controls.Add(this.checkBoxFirefox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxChrome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxChrome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxFirefox;
        private System.Windows.Forms.CheckBox checkBoxOpera;
        private System.Windows.Forms.CheckBox checkBoxOperaGX;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
    }
}


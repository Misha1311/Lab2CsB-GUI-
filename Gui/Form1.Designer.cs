namespace Gui
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AvgSqu = new System.Windows.Forms.Label();
            this.MinPer = new System.Windows.Forms.Label();
            this.MaxHyp = new System.Windows.Forms.Label();
            this.Start1 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.RichTextBox();
            this.excp = new System.Windows.Forms.Label();
            this.OupN = new System.Windows.Forms.TextBox();
            this.OupM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите количество треугольников:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите кол-во прямоугольных треугольников:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cредняя площадь  =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Минимальный периметр  =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(584, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Прямоуголный треугольник с наибольшей гипотенузой = ";
            // 
            // AvgSqu
            // 
            this.AvgSqu.BackColor = System.Drawing.Color.Transparent;
            this.AvgSqu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvgSqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgSqu.Location = new System.Drawing.Point(235, 300);
            this.AvgSqu.Name = "AvgSqu";
            this.AvgSqu.Size = new System.Drawing.Size(141, 24);
            this.AvgSqu.TabIndex = 9;
            this.AvgSqu.Text = "0";
            // 
            // MinPer
            // 
            this.MinPer.BackColor = System.Drawing.Color.Transparent;
            this.MinPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinPer.Location = new System.Drawing.Point(297, 350);
            this.MinPer.Name = "MinPer";
            this.MinPer.Size = new System.Drawing.Size(141, 24);
            this.MinPer.TabIndex = 10;
            this.MinPer.Text = "0";
            // 
            // MaxHyp
            // 
            this.MaxHyp.BackColor = System.Drawing.Color.Transparent;
            this.MaxHyp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxHyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxHyp.Location = new System.Drawing.Point(605, 400);
            this.MaxHyp.Name = "MaxHyp";
            this.MaxHyp.Size = new System.Drawing.Size(141, 24);
            this.MaxHyp.TabIndex = 11;
            this.MaxHyp.Text = "0";
            // 
            // Start1
            // 
            this.Start1.BackColor = System.Drawing.Color.Transparent;
            this.Start1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start1.FlatAppearance.BorderSize = 0;
            this.Start1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start1.Location = new System.Drawing.Point(611, 24);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(145, 38);
            this.Start1.TabIndex = 3;
            this.Start1.Text = "Посчитать";
            this.Start1.UseVisualStyleBackColor = false;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(19, 77);
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(419, 220);
            this.info.TabIndex = 5;
            this.info.Text = "";
            // 
            // excp
            // 
            this.excp.AutoSize = true;
            this.excp.BackColor = System.Drawing.Color.Transparent;
            this.excp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excp.Location = new System.Drawing.Point(499, 95);
            this.excp.Name = "excp";
            this.excp.Size = new System.Drawing.Size(0, 20);
            this.excp.TabIndex = 15;
            // 
            // OupN
            // 
            this.OupN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupN.Location = new System.Drawing.Point(500, 10);
            this.OupN.Name = "OupN";
            this.OupN.Size = new System.Drawing.Size(75, 29);
            this.OupN.TabIndex = 1;
            // 
            // OupM
            // 
            this.OupM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupM.Location = new System.Drawing.Point(500, 50);
            this.OupM.Name = "OupM";
            this.OupM.Size = new System.Drawing.Size(75, 29);
            this.OupM.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.OupM);
            this.Controls.Add(this.OupN);
            this.Controls.Add(this.excp);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Start1);
            this.Controls.Add(this.MaxHyp);
            this.Controls.Add(this.MinPer);
            this.Controls.Add(this.AvgSqu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AvgSqu;
        private System.Windows.Forms.Label MinPer;
        private System.Windows.Forms.Label MaxHyp;
        private System.Windows.Forms.Button Start1;
        public System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Label excp;
        private System.Windows.Forms.TextBox OupN;
        private System.Windows.Forms.TextBox OupM;
    }
}


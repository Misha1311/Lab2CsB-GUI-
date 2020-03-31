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
            this.OupM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.oupavsq = new System.Windows.Forms.Label();
            this.oupminper = new System.Windows.Forms.Label();
            this.oupmaxhyp = new System.Windows.Forms.Label();
            this.OupN = new System.Windows.Forms.TextBox();
            this.Start1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OupM
            // 
            this.OupM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupM.Location = new System.Drawing.Point(500, 50);
            this.OupM.Multiline = true;
            this.OupM.Name = "OupM";
            this.OupM.Size = new System.Drawing.Size(75, 25);
            this.OupM.TabIndex = 1;
            this.OupM.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите количество трехугольников:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите номер прямоугольного треугольника:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(584, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Прямоуголный треугольник с наибольшей гипотенузой = ";
            // 
            // oupavsq
            // 
            this.oupavsq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oupavsq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oupavsq.Location = new System.Drawing.Point(242, 300);
            this.oupavsq.Name = "oupavsq";
            this.oupavsq.Size = new System.Drawing.Size(141, 24);
            this.oupavsq.TabIndex = 9;
            this.oupavsq.Text = "0";
            // 
            // oupminper
            // 
            this.oupminper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oupminper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oupminper.Location = new System.Drawing.Point(297, 350);
            this.oupminper.Name = "oupminper";
            this.oupminper.Size = new System.Drawing.Size(141, 24);
            this.oupminper.TabIndex = 10;
            this.oupminper.Text = "0";
            // 
            // oupmaxhyp
            // 
            this.oupmaxhyp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oupmaxhyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oupmaxhyp.Location = new System.Drawing.Point(605, 400);
            this.oupmaxhyp.Name = "oupmaxhyp";
            this.oupmaxhyp.Size = new System.Drawing.Size(141, 24);
            this.oupmaxhyp.TabIndex = 11;
            this.oupmaxhyp.Text = "0";
            // 
            // OupN
            // 
            this.OupN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupN.Location = new System.Drawing.Point(500, 10);
            this.OupN.Multiline = true;
            this.OupN.Name = "OupN";
            this.OupN.Size = new System.Drawing.Size(75, 25);
            this.OupN.TabIndex = 12;
            this.OupN.Text = "0";
            // 
            // Start1
            // 
            this.Start1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start1.Location = new System.Drawing.Point(611, 24);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(145, 38);
            this.Start1.TabIndex = 13;
            this.Start1.Text = "Посчитать";
            this.Start1.UseVisualStyleBackColor = true;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(140)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.Start1);
            this.Controls.Add(this.OupN);
            this.Controls.Add(this.oupmaxhyp);
            this.Controls.Add(this.oupminper);
            this.Controls.Add(this.oupavsq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OupM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OupM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label oupavsq;
        private System.Windows.Forms.Label oupminper;
        private System.Windows.Forms.Label oupmaxhyp;
        private System.Windows.Forms.TextBox OupN;
        private System.Windows.Forms.Button Start1;
    }
}


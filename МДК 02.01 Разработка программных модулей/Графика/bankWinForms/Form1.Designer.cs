namespace bankWinForms
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
            this.labelSum = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.TBSum = new System.Windows.Forms.TextBox();
            this.TBTime = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textFinish = new System.Windows.Forms.TextBox();
            this.labelFinish = new System.Windows.Forms.Label();
            this.listCalcs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(12, 25);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(214, 24);
            this.labelSum.TabIndex = 0;
            this.labelSum.Text = "Введите сумму вклада";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 95);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(201, 24);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Введите срок вклада";
            // 
            // TBSum
            // 
            this.TBSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSum.Location = new System.Drawing.Point(16, 52);
            this.TBSum.Name = "TBSum";
            this.TBSum.Size = new System.Drawing.Size(210, 26);
            this.TBSum.TabIndex = 2;
            // 
            // TBTime
            // 
            this.TBTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBTime.Location = new System.Drawing.Point(16, 122);
            this.TBTime.Name = "TBTime";
            this.TBTime.Size = new System.Drawing.Size(210, 26);
            this.TBTime.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(52, 211);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(130, 36);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textFinish
            // 
            this.textFinish.Enabled = false;
            this.textFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFinish.Location = new System.Drawing.Point(311, 221);
            this.textFinish.Name = "textFinish";
            this.textFinish.Size = new System.Drawing.Size(296, 26);
            this.textFinish.TabIndex = 6;
            this.textFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinish.Location = new System.Drawing.Point(332, 194);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(249, 24);
            this.labelFinish.TabIndex = 7;
            this.labelFinish.Text = "Итоговая сумма на вкладе";
            // 
            // listCalcs
            // 
            this.listCalcs.Enabled = false;
            this.listCalcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listCalcs.FormattingEnabled = true;
            this.listCalcs.ItemHeight = 20;
            this.listCalcs.Location = new System.Drawing.Point(277, 25);
            this.listCalcs.Name = "listCalcs";
            this.listCalcs.Size = new System.Drawing.Size(363, 144);
            this.listCalcs.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 288);
            this.Controls.Add(this.listCalcs);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.textFinish);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.TBTime);
            this.Controls.Add(this.TBSum);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSum);
            this.Name = "Form1";
            this.Text = "Банковские вклады";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox TBSum;
        private System.Windows.Forms.TextBox TBTime;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textFinish;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.ListBox listCalcs;
    }
}


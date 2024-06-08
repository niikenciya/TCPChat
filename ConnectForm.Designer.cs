namespace TCPChat
{
    partial class ConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipTxt
            // 
            this.ipTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipTxt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipTxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ipTxt.Location = new System.Drawing.Point(12, 12);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(366, 44);
            this.ipTxt.TabIndex = 1;
            this.ipTxt.Text = "ip сервера";
            this.ipTxt.TextChanged += new System.EventHandler(this.ipTxt_TextChanged);
            this.ipTxt.Enter += new System.EventHandler(this.textBox1_Enter);
            this.ipTxt.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nameTxt.Location = new System.Drawing.Point(12, 112);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(366, 44);
            this.nameTxt.TabIndex = 3;
            this.nameTxt.Text = "имя";
            this.nameTxt.Enter += new System.EventHandler(this.textBox4_Enter);
            this.nameTxt.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // portTxt
            // 
            this.portTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portTxt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.portTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portTxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.portTxt.Location = new System.Drawing.Point(12, 62);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(366, 44);
            this.portTxt.TabIndex = 2;
            this.portTxt.Text = "порт сервера";
            this.portTxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.portTxt.Enter += new System.EventHandler(this.textBox5_Enter);
            this.portTxt.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(275, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "подключиться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(390, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.ipTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectForm";
            this.Text = "ConnectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Button button1;
    }
}


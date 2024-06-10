namespace Client
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
            this.Loader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).BeginInit();
            this.SuspendLayout();
            // 
            // ipTxt
            // 
            this.ipTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ipTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipTxt.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipTxt.ForeColor = System.Drawing.Color.Gray;
            this.ipTxt.Location = new System.Drawing.Point(12, 12);
            this.ipTxt.MaxLength = 15;
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(245, 34);
            this.ipTxt.TabIndex = 1;
            this.ipTxt.Text = "Ip сервера";
            this.ipTxt.TextChanged += new System.EventHandler(this.ipTxt_TextChanged);
            this.ipTxt.Enter += new System.EventHandler(this.textBox1_Enter);
            this.ipTxt.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTxt.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxt.ForeColor = System.Drawing.Color.Gray;
            this.nameTxt.Location = new System.Drawing.Point(12, 112);
            this.nameTxt.MaxLength = 15;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(245, 34);
            this.nameTxt.TabIndex = 3;
            this.nameTxt.Text = "Имя";
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            this.nameTxt.Enter += new System.EventHandler(this.textBox4_Enter);
            this.nameTxt.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // portTxt
            // 
            this.portTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.portTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portTxt.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portTxt.ForeColor = System.Drawing.Color.Gray;
            this.portTxt.Location = new System.Drawing.Point(12, 62);
            this.portTxt.MaxLength = 5;
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(245, 34);
            this.portTxt.TabIndex = 2;
            this.portTxt.Text = "Порт сервера";
            this.portTxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.portTxt.Enter += new System.EventHandler(this.textBox5_Enter);
            this.portTxt.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(153, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подключиться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loader
            // 
            this.Loader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Loader.Image = global::TCPChat.Properties.Resources.Eqjd;
            this.Loader.Location = new System.Drawing.Point(12, 12);
            this.Loader.Name = "Loader";
            this.Loader.Size = new System.Drawing.Size(245, 193);
            this.Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Loader.TabIndex = 4;
            this.Loader.TabStop = false;
            this.Loader.Visible = false;
            // 
            // ConnectForm
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(269, 221);
            this.Controls.Add(this.Loader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.ipTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(285, 260);
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectForm";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Loader;
    }
}


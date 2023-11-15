namespace Товары_для_животных
{
    partial class Autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pnl_Box = new System.Windows.Forms.Panel();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.box_Visit = new System.Windows.Forms.Label();
            this.check_Password = new System.Windows.Forms.CheckBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.box_Password = new System.Windows.Forms.TextBox();
            this.box_Login = new System.Windows.Forms.TextBox();
            this.box_Image = new System.Windows.Forms.PictureBox();
            this.pnl_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(170, 90);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(97, 45);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Вход";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Name.Location = new System.Drawing.Point(60, 85);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(495, 45);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "ООО \"Товары для животных\"";
            // 
            // pnl_Box
            // 
            this.pnl_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Box.Controls.Add(this.lbl_Exit);
            this.pnl_Box.Controls.Add(this.box_Visit);
            this.pnl_Box.Controls.Add(this.check_Password);
            this.pnl_Box.Controls.Add(this.btn_Enter);
            this.pnl_Box.Controls.Add(this.lbl_Password);
            this.pnl_Box.Controls.Add(this.lbl_Login);
            this.pnl_Box.Controls.Add(this.box_Password);
            this.pnl_Box.Controls.Add(this.box_Login);
            this.pnl_Box.Controls.Add(this.lbl_Title);
            this.pnl_Box.Location = new System.Drawing.Point(630, -10);
            this.pnl_Box.Name = "pnl_Box";
            this.pnl_Box.Size = new System.Drawing.Size(450, 710);
            this.pnl_Box.TabIndex = 2;
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.lbl_Exit.Location = new System.Drawing.Point(340, 10);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(90, 33);
            this.lbl_Exit.TabIndex = 9;
            this.lbl_Exit.Text = "Выйти";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // box_Visit
            // 
            this.box_Visit.AutoSize = true;
            this.box_Visit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_Visit.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Visit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.box_Visit.Location = new System.Drawing.Point(116, 480);
            this.box_Visit.Name = "box_Visit";
            this.box_Visit.Size = new System.Drawing.Size(234, 39);
            this.box_Visit.TabIndex = 8;
            this.box_Visit.Text = "Войти как Гость";
            this.box_Visit.Click += new System.EventHandler(this.box_Visit_Click);
            // 
            // check_Password
            // 
            this.check_Password.AutoSize = true;
            this.check_Password.Checked = true;
            this.check_Password.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Password.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_Password.Location = new System.Drawing.Point(390, 330);
            this.check_Password.Name = "check_Password";
            this.check_Password.Size = new System.Drawing.Size(22, 21);
            this.check_Password.TabIndex = 7;
            this.check_Password.UseVisualStyleBackColor = true;
            this.check_Password.CheckedChanged += new System.EventHandler(this.check_Password_CheckedChanged);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btn_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Enter.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Enter.ForeColor = System.Drawing.Color.White;
            this.btn_Enter.Location = new System.Drawing.Point(136, 405);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(195, 65);
            this.btn_Enter.TabIndex = 5;
            this.btn_Enter.Text = "Войти";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.box_Enter_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.White;
            this.lbl_Password.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Password.Location = new System.Drawing.Point(65, 290);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(86, 28);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Пароль";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.White;
            this.lbl_Login.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Login.Location = new System.Drawing.Point(65, 190);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(72, 28);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "Логин";
            // 
            // box_Password
            // 
            this.box_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.box_Password.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Password.Location = new System.Drawing.Point(67, 316);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(315, 47);
            this.box_Password.TabIndex = 2;
            this.box_Password.UseSystemPasswordChar = true;
            // 
            // box_Login
            // 
            this.box_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.box_Login.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Login.Location = new System.Drawing.Point(65, 215);
            this.box_Login.Name = "box_Login";
            this.box_Login.Size = new System.Drawing.Size(315, 47);
            this.box_Login.TabIndex = 1;
            // 
            // box_Image
            // 
            this.box_Image.Image = global::Товары_для_животных.Properties.Resources.logo;
            this.box_Image.Location = new System.Drawing.Point(140, 140);
            this.box_Image.Name = "box_Image";
            this.box_Image.Size = new System.Drawing.Size(355, 390);
            this.box_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box_Image.TabIndex = 3;
            this.box_Image.TabStop = false;
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.box_Image);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pnl_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.pnl_Box.ResumeLayout(false);
            this.pnl_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Panel pnl_Box;
        private System.Windows.Forms.PictureBox box_Image;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox box_Password;
        private System.Windows.Forms.TextBox box_Login;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.CheckBox check_Password;
        private System.Windows.Forms.Label box_Visit;
        private System.Windows.Forms.Label lbl_Exit;
    }
}


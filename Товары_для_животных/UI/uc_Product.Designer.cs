namespace Товары_для_животных.UI
{
    partial class uc_Product
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_Image = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_Manuf = new System.Windows.Forms.Label();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.group_box = new System.Windows.Forms.GroupBox();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.box_Check = new System.Windows.Forms.CheckBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).BeginInit();
            this.group_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_Image
            // 
            this.box_Image.Location = new System.Drawing.Point(10, 15);
            this.box_Image.Name = "box_Image";
            this.box_Image.Size = new System.Drawing.Size(265, 265);
            this.box_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box_Image.TabIndex = 4;
            this.box_Image.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.lbl_Name.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(285, 15);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(223, 39);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Наименование";
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.BackColor = System.Drawing.Color.White;
            this.lbl_Desc.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Desc.Location = new System.Drawing.Point(285, 60);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(460, 145);
            this.lbl_Desc.TabIndex = 6;
            this.lbl_Desc.Text = "Описание \r\n";
            // 
            // lbl_Manuf
            // 
            this.lbl_Manuf.AutoSize = true;
            this.lbl_Manuf.BackColor = System.Drawing.Color.White;
            this.lbl_Manuf.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Manuf.Location = new System.Drawing.Point(285, 215);
            this.lbl_Manuf.Name = "lbl_Manuf";
            this.lbl_Manuf.Size = new System.Drawing.Size(171, 28);
            this.lbl_Manuf.TabIndex = 7;
            this.lbl_Manuf.Text = "Производитель:";
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.AutoSize = true;
            this.lbl_Cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.lbl_Cost.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Cost.ForeColor = System.Drawing.Color.White;
            this.lbl_Cost.Location = new System.Drawing.Point(285, 250);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(65, 28);
            this.lbl_Cost.TabIndex = 8;
            this.lbl_Cost.Text = "Цена:";
            // 
            // group_box
            // 
            this.group_box.Controls.Add(this.lbl_Count);
            this.group_box.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_box.Location = new System.Drawing.Point(800, 70);
            this.group_box.Name = "group_box";
            this.group_box.Size = new System.Drawing.Size(135, 125);
            this.group_box.TabIndex = 9;
            this.group_box.TabStop = false;
            this.group_box.Text = "На складе";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.BackColor = System.Drawing.Color.White;
            this.lbl_Count.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Count.Location = new System.Drawing.Point(45, 60);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(36, 28);
            this.lbl_Count.TabIndex = 9;
            this.lbl_Count.Text = "шт";
            // 
            // box_Check
            // 
            this.box_Check.AutoSize = true;
            this.box_Check.Location = new System.Drawing.Point(950, 136);
            this.box_Check.Name = "box_Check";
            this.box_Check.Size = new System.Drawing.Size(22, 21);
            this.box_Check.TabIndex = 10;
            this.box_Check.UseVisualStyleBackColor = true;
            this.box_Check.Visible = false;
            this.box_Check.CheckedChanged += new System.EventHandler(this.box_Check_CheckedChanged);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.White;
            this.lbl_ID.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ID.Location = new System.Drawing.Point(955, 5);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(37, 28);
            this.lbl_ID.TabIndex = 11;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
            // 
            // uc_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.box_Check);
            this.Controls.Add(this.group_box);
            this.Controls.Add(this.lbl_Cost);
            this.Controls.Add(this.lbl_Manuf);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.box_Image);
            this.Name = "uc_Product";
            this.Size = new System.Drawing.Size(998, 293);
            this.Load += new System.EventHandler(this.uc_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).EndInit();
            this.group_box.ResumeLayout(false);
            this.group_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box_Image;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Label lbl_Manuf;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.GroupBox group_box;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.CheckBox box_Check;
        private System.Windows.Forms.Label lbl_ID;
    }
}

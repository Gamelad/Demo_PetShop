namespace Товары_для_животных
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.box_Visit = new System.Windows.Forms.Label();
            this.pnl_Product = new System.Windows.Forms.FlowLayoutPanel();
            this.box_Filter = new System.Windows.Forms.ComboBox();
            this.box_Sort = new System.Windows.Forms.ComboBox();
            this.box_Search = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Name.Location = new System.Drawing.Point(950, 5);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(271, 35);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Окно администратора";
            // 
            // box_Visit
            // 
            this.box_Visit.AutoSize = true;
            this.box_Visit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_Visit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Visit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.box_Visit.Location = new System.Drawing.Point(0, 0);
            this.box_Visit.Name = "box_Visit";
            this.box_Visit.Size = new System.Drawing.Size(111, 33);
            this.box_Visit.TabIndex = 10;
            this.box_Visit.Text = "<--Назад";
            this.box_Visit.Click += new System.EventHandler(this.box_Visit_Click);
            // 
            // pnl_Product
            // 
            this.pnl_Product.AutoScroll = true;
            this.pnl_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.pnl_Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Product.Location = new System.Drawing.Point(5, 45);
            this.pnl_Product.Name = "pnl_Product";
            this.pnl_Product.Size = new System.Drawing.Size(1045, 610);
            this.pnl_Product.TabIndex = 11;
            // 
            // box_Filter
            // 
            this.box_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Filter.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Filter.FormattingEnabled = true;
            this.box_Filter.Location = new System.Drawing.Point(720, 5);
            this.box_Filter.Name = "box_Filter";
            this.box_Filter.Size = new System.Drawing.Size(220, 31);
            this.box_Filter.TabIndex = 16;
            this.box_Filter.SelectedIndexChanged += new System.EventHandler(this.box_Filter_SelectedIndexChanged);
            // 
            // box_Sort
            // 
            this.box_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Sort.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Sort.FormattingEnabled = true;
            this.box_Sort.Items.AddRange(new object[] {
            "Без сортировки",
            "По возрастанию",
            "По убыванию"});
            this.box_Sort.Location = new System.Drawing.Point(490, 5);
            this.box_Sort.Name = "box_Sort";
            this.box_Sort.Size = new System.Drawing.Size(220, 31);
            this.box_Sort.TabIndex = 15;
            this.box_Sort.SelectedIndexChanged += new System.EventHandler(this.box_Sort_SelectedIndexChanged);
            // 
            // box_Search
            // 
            this.box_Search.BackColor = System.Drawing.Color.White;
            this.box_Search.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Search.Location = new System.Drawing.Point(120, 5);
            this.box_Search.Name = "box_Search";
            this.box_Search.Size = new System.Drawing.Size(360, 30);
            this.box_Search.TabIndex = 14;
            this.box_Search.TextChanged += new System.EventHandler(this.box_Search_TextChanged);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.BackColor = System.Drawing.Color.White;
            this.lbl_Result.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Result.Location = new System.Drawing.Point(965, 625);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(82, 28);
            this.lbl_Result.TabIndex = 17;
            this.lbl_Result.Text = "0 из 30";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1055, 49);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(166, 65);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btn_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.Location = new System.Drawing.Point(1056, 125);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(166, 65);
            this.btn_Create.TabIndex = 19;
            this.btn_Create.Text = "Изменить";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(1056, 200);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(166, 65);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 664);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.box_Filter);
            this.Controls.Add(this.box_Sort);
            this.Controls.Add(this.box_Search);
            this.Controls.Add(this.pnl_Product);
            this.Controls.Add(this.box_Visit);
            this.Controls.Add(this.lbl_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1250, 720);
            this.MinimumSize = new System.Drawing.Size(1250, 720);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно администратора";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label box_Visit;
        private System.Windows.Forms.FlowLayoutPanel pnl_Product;
        private System.Windows.Forms.ComboBox box_Filter;
        private System.Windows.Forms.ComboBox box_Sort;
        private System.Windows.Forms.TextBox box_Search;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Delete;
    }
}
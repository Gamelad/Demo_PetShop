namespace Товары_для_животных
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.box_Visit = new System.Windows.Forms.Label();
            this.pnl_Product = new System.Windows.Forms.FlowLayoutPanel();
            this.box_Search = new System.Windows.Forms.TextBox();
            this.box_Sort = new System.Windows.Forms.ComboBox();
            this.box_Filter = new System.Windows.Forms.ComboBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Name.Location = new System.Drawing.Point(855, 5);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(198, 35);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Список товаров";
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
            this.box_Visit.TabIndex = 9;
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
            this.pnl_Product.TabIndex = 10;
            // 
            // box_Search
            // 
            this.box_Search.BackColor = System.Drawing.Color.White;
            this.box_Search.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Search.Location = new System.Drawing.Point(120, 5);
            this.box_Search.Name = "box_Search";
            this.box_Search.Size = new System.Drawing.Size(265, 30);
            this.box_Search.TabIndex = 11;
            this.box_Search.TextChanged += new System.EventHandler(this.box_Search_TextChanged);
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
            this.box_Sort.Location = new System.Drawing.Point(395, 5);
            this.box_Sort.Name = "box_Sort";
            this.box_Sort.Size = new System.Drawing.Size(220, 31);
            this.box_Sort.TabIndex = 12;
            this.box_Sort.SelectedIndexChanged += new System.EventHandler(this.box_Sort_SelectedIndexChanged);
            // 
            // box_Filter
            // 
            this.box_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Filter.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Filter.FormattingEnabled = true;
            this.box_Filter.Location = new System.Drawing.Point(625, 5);
            this.box_Filter.Name = "box_Filter";
            this.box_Filter.Size = new System.Drawing.Size(220, 31);
            this.box_Filter.TabIndex = 13;
            this.box_Filter.SelectedIndexChanged += new System.EventHandler(this.box_Filter_SelectedIndexChanged);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.BackColor = System.Drawing.Color.White;
            this.lbl_Result.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Result.Location = new System.Drawing.Point(965, 625);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(82, 28);
            this.lbl_Result.TabIndex = 14;
            this.lbl_Result.Text = "0 из 30";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.box_Filter);
            this.Controls.Add(this.box_Sort);
            this.Controls.Add(this.box_Search);
            this.Controls.Add(this.pnl_Product);
            this.Controls.Add(this.box_Visit);
            this.Controls.Add(this.lbl_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список товаров";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label box_Visit;
        private System.Windows.Forms.FlowLayoutPanel pnl_Product;
        private System.Windows.Forms.TextBox box_Search;
        private System.Windows.Forms.ComboBox box_Sort;
        private System.Windows.Forms.ComboBox box_Filter;
        private System.Windows.Forms.Label lbl_Result;
    }
}
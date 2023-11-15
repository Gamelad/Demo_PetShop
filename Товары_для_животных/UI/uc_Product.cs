using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Товары_для_животных.Autorization;

namespace Товары_для_животных.UI
{
    public partial class uc_Product : UserControl
    {
        /// <summary>
        /// Переменная для ID записи
        /// </summary>
        public static int a_id {  get; set; }
        public uc_Product()
        {
            InitializeComponent();
        }

        public static class Product
        {
            public static int ID;
        }

        private void uc_Product_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = db_Connect.fromDB($"select*from Products where ProductID = {a_id}");
                for (int i = 0;  i < table.Rows.Count; i++)
                {
                    lbl_ID.Text = $"{table.Rows[i][0]}";
                    lbl_Name.Text = $"{table.Rows[i][2]}";
                    lbl_Desc.Text = $"{table.Rows[i][11]}";
                    lbl_Manuf.Text += $" {table.Rows[i][6]}";
                    lbl_Cost.Text += $" {table.Rows[i][4]} руб.";
                    lbl_Count.Text = $"{table.Rows[i][10]} шт.";
                    if (table.Rows[i][12].ToString() == "")
                    {
                        box_Image.Image = Image.FromFile(@"Images\picture.png");
                    }
                    else
                    {
                        box_Image.Image = Image.FromFile($@"Images\{table.Rows[i][12]}");
                    }               
                }
                if (Role.ID == 1)
                {
                    box_Check.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void box_Check_CheckedChanged(object sender, EventArgs e)
        {
            Product.ID = Convert.ToInt32(lbl_ID.Text);
        }
    }
}

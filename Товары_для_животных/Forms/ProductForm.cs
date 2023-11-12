using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Товары_для_животных.UI;

namespace Товары_для_животных
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void box_Visit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Autorization autorization = new Autorization();
                autorization.Show();
                this.Close();
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            box_Filter.Items.Add("Все производители");
            DataTable table = db_Connect.fromDB("select*from Products");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (box_Filter.Items.Contains(table.Rows[i][6].ToString()) == false)
                    box_Filter.Items.Add(table.Rows[i][6].ToString());
            }

            UC_Load();
        }
        /// <summary>
        /// Метод отображения UserControls
        /// </summary>
        private void UC_Load()
        {
            try
            {
                int result = 0;
                pnl_Product.Controls.Clear();
                DataTable table = db_Connect.fromDB("select*from Products");
                for (int i = 0;  i < table.Rows.Count; i++)
                {
                    uc_Product uc = new uc_Product();
                    uc_Product.a_id = (int)table.Rows[i][0];
                    pnl_Product.Controls.Add(uc);
                    result++;
                }
                lbl_Result.Text = $"{result} из {table.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод сортировки UserControls
        /// </summary>
        private void Sort()
        {
            try
            {
                int result = 0;
                pnl_Product.Controls.Clear();
                switch (box_Sort.SelectedIndex)
                {
                    case 0:
                        UC_Load();
                        break;
                    case 1:
                        DataTable table = db_Connect.fromDB("select*from Products order by ProductCost asc");
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            uc_Product uc = new uc_Product();
                            uc_Product.a_id = (int)table.Rows[i][0];
                            pnl_Product.Controls.Add(uc);
                            result++;
                        }
                        lbl_Result.Text = $"{result} из {table.Rows.Count}";
                        break;
                    case 2:
                        table = db_Connect.fromDB("select*from Products order by ProductCost desc");
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            uc_Product uc = new uc_Product();
                            uc_Product.a_id = (int)table.Rows[i][0];
                            pnl_Product.Controls.Add(uc);
                            result++;
                        }
                        lbl_Result.Text = $"{result} из {table.Rows.Count}";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод фильтрации UserControls
        /// </summary>
        private void Filter()
        {
            try
            {
                if (box_Filter.SelectedIndex != 0)
                {
                    int result = 0;
                    pnl_Product.Controls.Clear();
                    DataTable table = db_Connect.fromDB($"select*from Products where ProductManufacturer like '%{box_Filter.SelectedItem}%'");
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        uc_Product uc = new uc_Product();
                        uc_Product.a_id = (int)table.Rows[i][0];
                        pnl_Product.Controls.Add(uc);
                        result++;
                    }
                    lbl_Result.Text = $"{result} из 30";
                }
                if (box_Filter.SelectedIndex == 0)
                {
                    UC_Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Метод поиска UserControls
        /// </summary>
        private void Search()
        {
            try
            {
                if (box_Search.Text != "")
                {
                    int result = 0;
                    pnl_Product.Controls.Clear();
                    DataTable table = db_Connect.fromDB($"select*from Products where ProductManufacturer like '%{box_Search.Text}%' or ProductName like '%{box_Search.Text}%' or ProductDescription like '%{box_Search.Text}%' or ProductCost like '%{box_Search.Text}%' or ProductQuantityInStock like '%{box_Search.Text}%'");
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        uc_Product uc = new uc_Product();
                        uc_Product.a_id = (int)table.Rows[i][0];
                        pnl_Product.Controls.Add(uc);
                        result++;
                    }
                    lbl_Result.Text = $"{result} из 30";
                }
                if (box_Search.Text == "")
                {
                    UC_Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void box_Search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void box_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void box_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}

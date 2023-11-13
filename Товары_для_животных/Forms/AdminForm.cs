using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Товары_для_животных.Forms;
using Товары_для_животных.UI;

namespace Товары_для_животных
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
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
        /// Метод отображения, сортировки, поиска, фильтрации UserControls с помощью хранимой процедуры SQL-server
        /// </summary>
        private void UC_Load()
        {
            try
            {
                int result = 0;
                pnl_Product.Controls.Clear();
                DataTable table = db_Connect.fromDB($"execute sp_FilterSort '{box_Filter.SelectedItem}','{box_Sort.SelectedIndex}','{box_Search.Text}'");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    uc_Product uc = new uc_Product();
                    uc_Product.a_id = (int)table.Rows[i][0];
                    pnl_Product.Controls.Add(uc);
                    result++;
                }
                DataTable table1 = db_Connect.fromDB("select*from Products");
                lbl_Result.Text = $"{result} из {table1.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void box_Search_TextChanged(object sender, EventArgs e)
        {
            UC_Load();
        }

        private void box_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UC_Load();
        }

        private void box_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UC_Load();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddCreateForm addCreateForm = new AddCreateForm();
            addCreateForm.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Товар не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Товары_для_животных.AdminForm;
using static Товары_для_животных.Autorization;
using static Товары_для_животных.UI.uc_Product;

namespace Товары_для_животных.Forms
{
    public partial class AddCreateForm : Form
    {
        public AddCreateForm()
        {
            InitializeComponent();
        }

        private void box_Visit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите выйти?","Выход",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                switch (AddCreate.Value)
                {
                    case "Add":
                        DataTable table = db_Connect.fromDB("select*from Products");
                        db_Connect.toDB($"execute sp_AddCreate 'Add','{table.Rows.Count + 1}','{box_Name.Text}','{box_Desc.Text}','{box_Manuf.Text}','{Convert.ToInt32(box_Cost.Text)}'");
                        MessageBox.Show("Товар успешно добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                    case "Create":
                        db_Connect.toDB($"execute sp_AddCreate 'Create','{Product.ID}','{box_Name.Text}','{box_Desc.Text}','{box_Manuf.Text}','{Convert.ToInt32(box_Cost.Text)}'");
                        MessageBox.Show("Данные товара успешно изменены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCreateForm_Load(object sender, EventArgs e)
        {
            if (AddCreate.Value == "Create")
            {
                DataTable table = db_Connect.fromDB($"select*from Products where ProductID = {Product.ID}");
                for (int i = 0;  i < table.Rows.Count; i++)
                {
                    box_Article.Text = $"{table.Rows[i][1]}";
                    box_Name.Text = $"{table.Rows[i][2]}";
                    box_Unit.Text = $"{table.Rows[i][3]}";
                    box_Cost.Text = $"{table.Rows[i][4]}";
                    box_Max.Text = $"{table.Rows[i][5]}";
                    box_Manuf.Text = $"{table.Rows[i][6]}";
                    box_Provider.Text = $"{table.Rows[i][7]}";
                    box_Category.Text = $"{table.Rows[i][8]}";
                    box_Discount.Text = $"{table.Rows[i][9]}";
                    box_Count.Text = $"{table.Rows[i][10]}";
                    box_Desc.Text = $"{table.Rows[i][11]}";
                    box_Image.Text = $"{table.Rows[i][12]}";
                }
            }
        }
    }
}

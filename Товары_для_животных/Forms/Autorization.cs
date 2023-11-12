using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Товары_для_животных
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void check_Password_CheckedChanged(object sender, EventArgs e)
        {
            box_Password.UseSystemPasswordChar = !box_Password.UseSystemPasswordChar;
        }
        
        private void box_Enter_Click(object sender, EventArgs e)
        {
            click_Autorization();
        }
        /// <summary>
        /// Метод авторизации пользователя
        /// </summary>
        private void click_Autorization()
        {
            try
            {
                bool open = false;
                DataTable table = db_Connect.fromDB("select*from Users");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (box_Login.Text == table.Rows[i][4].ToString() && box_Password.Text == table.Rows[i][5].ToString())
                    {
                        switch (table.Rows[i][6])
                        {
                            case 1:
                                MessageBox.Show($"Добро пожаловать, {table.Rows[i][2]} {table.Rows[i][3]}!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                open = true;
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                                this.Hide();
                                break;
                            case 2:
                                MessageBox.Show($"Добро пожаловать, {table.Rows[i][2]} {table.Rows[i][3]}!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                open = true;
                                ProductForm managForm = new ProductForm();
                                managForm.Show();
                                this.Hide();
                                break;
                            case 3:
                                MessageBox.Show($"Добро пожаловать, {table.Rows[i][2]} {table.Rows[i][3]}!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                open = true;
                                ProductForm productForm = new ProductForm();
                                productForm.Show();
                                this.Hide();
                                break;
                        }
                    }
                }
                if (open == false)
                {
                    MessageBox.Show($"Некорректные данные для входа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void box_Visit_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
    }
}

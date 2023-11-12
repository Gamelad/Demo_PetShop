using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MessageBox.Show($"На данный момент функция отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

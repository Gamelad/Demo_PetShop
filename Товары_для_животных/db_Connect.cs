using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Товары_для_животных
{
    internal class db_Connect
    {
        /// <summary>
        /// Строка подкючения к БД
        /// </summary>
        public static string asd = @"Data Source = localhost; Initial Catalog = Pet_Products; Integrated Security = true";
        /// <summary>
        /// Соединение с БД
        /// </summary>
        /// <returns>Соединение готовое к подключению</returns>
        public static SqlConnection connection()
        {
            return new SqlConnection(asd);
        }
        /// <summary>
        /// Метод вызова данных из БД
        /// </summary>
        /// <param name="str">Строка SQL-запроса</param>
        /// <returns>Первую таблицу из DataSet или ничего</returns>
        public static DataTable fromDB (string str)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(str, connection());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                DataTable table = new DataTable();
                table = dataSet.Tables[0];
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex}","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }
        /// <summary>
        /// Метод для действия с БД
        /// </summary>
        /// <param name="stroke">Строка SQL-запроса</param>
        public static void toDB(string stroke)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(stroke, connection());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка действия: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

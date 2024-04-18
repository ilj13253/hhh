using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=LAPTOP-O676FMEF;Database=P_11_Academy_Butakov;Trusted_Connection=True";
        SqlDataAdapter ad = null;
        DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int keyToDelete = (int)numericUpDown1.Value; // Берем значение из numericUpDown1.Value, а не DecimalPlaces
                string query = $"DELETE FROM dbo.Teachers WHERE id=@KeyToDelete"; // Параметризуем запрос

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KeyToDelete", keyToDelete);
                        connection.Open();
                        command.ExecuteNonQuery();

                        // После выполнения операции DELETE, обновляем DataGridView, чтобы отобразить текущее состояние данных
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Teachers", connection); // Выбираем все данные из таблицы
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                        connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка SQL: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string t1 = textBox1.Text;
                string t2 = textBox6.Text;
                int n1 = numericUpDown2.DecimalPlaces;
                string n2 = textBox3.Text;
                string t3 = textBox5.Text;
                string t4 = textBox2.Text;
                DateTime d = dateTimePicker1.Value;
                string query = "INSERT INTO Teachers (EmploymentDate,Name_,Surname,Premium,Salary,IsAssistent,IsProfessor ) " +
                   "VALUES (@EmploymentDate, @Name_, @Surname,@Premium, @Salary, @IsAssistent, @IsProfessor)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@EmploymentDate", d);
                        command.Parameters.AddWithValue("@Name_", t1);
                        command.Parameters.AddWithValue("@Surname", t2);
                        command.Parameters.AddWithValue("@Premium", n1);
                        command.Parameters.AddWithValue("@Salary", n2);
                        command.Parameters.AddWithValue("@IsAssistent", t3);
                        command.Parameters.AddWithValue("@IsProfessor", t4);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Teachers", connection); // Выбираем все данные из таблицы
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка SQL: {ex.Message}");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string t1 = textBox10.Text;
                string t2 = textBox8.Text;
                int n1 = numericUpDown3.DecimalPlaces;
                string n2 = textBox4.Text;
                string t3 = textBox9.Text;
                string t4 = textBox7.Text;
                DateTime d = dateTimePicker2.Value;
                string query = "UPDATE dbo.Teachers SET EmploymentDate = @EmploymentDate, Name_ = @Name_, Surname = @Surname, Premium = @Premium, Salary = @Salary, IsAssistent = @IsAssistent, IsProfessor = @IsProfessor WHERE YourConditionHere";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@EmploymentDate", d);
                        command.Parameters.AddWithValue("@Name_", t1);
                        command.Parameters.AddWithValue("@Surname", t2);
                        command.Parameters.AddWithValue("@Premium", n1);
                        command.Parameters.AddWithValue("@Salary", n2);
                        command.Parameters.AddWithValue("@IsAssistent", t3);
                        command.Parameters.AddWithValue("@IsProfessor", t4);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Teachers", connection); // Выбираем все данные из таблицы
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show($"Ошибка SQL:{ex.Message}");
            }
        }
    }
}

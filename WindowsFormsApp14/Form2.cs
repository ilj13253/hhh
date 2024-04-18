using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace WindowsFormsApp14
{
    public partial class Form2 : Form
    {
        //private int count = 0;
       private SqlCommand sql = new SqlCommand();
        private DataTable t = new DataTable();
        private DataSet ds = new DataSet();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { var f = new Form1();
            //if ()
            //{
               MessageBox.Show("Вы успешно вышли!");
                f.ShowDialog();
            //}
            //else {
                MessageBox.Show("Не, правильный Логин и пароль:", "Ошибка:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //}
        }
    }
}

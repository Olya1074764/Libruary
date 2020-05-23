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

namespace Библиотека
{
    public partial class Readers : Form
    {
        public Readers()
        {
            InitializeComponent();
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            Readers j = new Readers();
            Hide();
            j.ShowDialog();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Operations h = new Operations();
            Hide();
            h.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NOTREADERS_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.FillByNOTREADERS(this.libDataSet.Student);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            label_ADD.Visible = false;
        }
        private void button_add_new_reader_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Lib;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "INSERT INTO Reader (ID_Student) VALUES('" + combobox_student.SelectedValue.ToString() + "');";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                }
                label_ADD.Visible = true;
            }
            catch (Exception)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Ошибка";
                label_ADD.Visible = true;
            }
            button4.Enabled = false;
        }

        private void READERS_Click(object sender, EventArgs e)
        {
            try
            {
                this.читателиTableAdapter.FillBy(this.libDataSet.Читатели);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=N354;Initial Catalog=Lib;Persist Security Info=False;User ID=sa;Password=Sa159753";
            try
            {
                string sqlExpression = "UPDATE Book_status SET [ID_reader] = null ,[Took] = null WHERE [ID_book] =" + comboBox2.SelectedValue.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    label10.Visible = true;
                }
            }
            catch (Exception)
            {
                label10.BackColor = System.Drawing.Color.OrangeRed;
                label10.Text = "Ошибка";
                label10.Visible = true;
            }
        }

        private void Readers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libDataSet.Список". При необходимости она может быть перемещена или удалена.
            this.списокTableAdapter.Fill(this.libDataSet.Список);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.libDataSet.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.libDataSet.Читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.libDataSet.Student);

        }

        private void ByКнига_датьClick(object sender, EventArgs e)
        {
            try
            {
                this.книгиTableAdapter.FillByКнига_дать(this.libDataSet.Книги);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy_Книга_принять_Click(object sender, EventArgs e)
        {
            try
            {
                this.книгиTableAdapter.FillBy_Книга_принять(this.libDataSet.Книги);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void combobox_student_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button6.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=N354;Initial Catalog=Lib;Persist Security Info=False;User ID=sa;Password=Sa159753";
            try
            {
                string sqlExpression = "UPDATE Book_status SET [ID_reader] = " + comboBox4.SelectedValue.ToString() +  ",[Took] ='" + System.DateTime.Now.Year.ToString() + "-" + System.DateTime.Now.Month.ToString() + "-" + System.DateTime.Now.Day.ToString() + "' WHERE [ID_book] =" + comboBox2.SelectedValue.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    label_del.Visible = true;
                }
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
                label_del.Visible = true;
            }
        }
    }
}

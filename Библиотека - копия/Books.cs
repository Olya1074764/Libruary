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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            Books g = new Books();
            Hide();
            g.ShowDialog();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Operations h = new Operations();
            Hide();
            h.ShowDialog();
        }

        private void button_add_new_book_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Lib;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "INSERT INTO Book([ID_Author], [name], [year_book])VALUES(" + add_book_autor_name_combobox.SelectedValue + ", '" + add_book_name_textbox.Text + "', '" + book_year_textbox.Text + "')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    label_ADD.Visible = true;
                    reader.Close();
                }
                string sqlExpression2 = "INSERT INTO Book_status([ID_book], [ID_reader], [Took])VALUES(" + add_book_autor_name_combobox.SelectedValue.ToString() + ", null , null" + ")";
                using (SqlConnection connection2 = new SqlConnection(connectionString))
                {
                    connection2.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection2);
                    SqlDataReader reader2 = command.ExecuteReader();
                    label_ADD.Visible = true;
                    reader2.Close();
                }
            }
            catch (Exception)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Ошибка";
                label_ADD.Visible = true;
            }
        }

        private void button_del_book_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=N354;Initial Catalog=Lib;Persist Security Info=False;User ID=sa;Password=Sa159753";
                string sqlExpression = "DELETE FROM BOOK WHERE ID =" + del_book_name_comboBox.SelectedValue.ToString() + ";";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                label_del.Visible = true;
                string sqlExpression2 = "DELETE FROM Book_status WHERE ID_book =" + del_book_name_comboBox.SelectedValue.ToString() + ";";
                using (SqlConnection connection2 = new SqlConnection(connectionString))
                {
                    connection2.Open();
                    SqlCommand command = new SqlCommand(sqlExpression2, connection2);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                label_del.Visible = true;
            }
            catch (Exception)
            {
                label_del.BackColor = System.Drawing.Color.OrangeRed;
                label_del.Text = "Ошибка";
                label_del.Visible = true;
            }
        }

        private void Autor_load(object sender, EventArgs e)
        {
            this.autorTableAdapter.Fill(this.libDataSet.Autor);
            try
            {
                this.autorTableAdapter.FillBy(this.libDataSet.Autor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Book_name_year_loud(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillBy1(this.libDataSet.Book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button_edit_name_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=N354;Initial Catalog=Lib;Persist Security Info=False;User ID=sa;Password=Sa159753";
            try
            {
                string sqlExpression = "UPDATE BOOK SET name = '" + UP_autor_name.Text.ToString() + "'" + "WHERE Book.ID = " + del_book_name_comboBox.SelectedValue;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                labe_edit_name.Visible = true;
            }
            catch (Exception)
            {
                labe_edit_name.BackColor = System.Drawing.Color.OrangeRed;
                labe_edit_name.Text = "Ошибка";
                labe_edit_name.Visible = true;
            }
        }

        private void button_edit_year_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=N354;Initial Catalog=Lib;Persist Security Info=False;User ID=sa;Password=Sa159753";
            try
            {
                string sqlExpression = "UPDATE BOOK SET year_book = '" + new_year_book_texbox.Text.ToString() + "'" + "WHERE Book.ID ='" +del_book_name_comboBox.SelectedValue + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                labe_edit_year.Visible = true;
                if (del_book_name_comboBox.Text == "")
                {
                    labe_edit_year.BackColor = System.Drawing.Color.OrangeRed;
                    labe_edit_year.Text = "Ошибка";
                    labe_edit_year.Visible = true;
                }
            }
            catch (Exception)
            {
                labe_edit_year.BackColor = System.Drawing.Color.OrangeRed;
                labe_edit_year.Text = "Ошибка";
                labe_edit_year.Visible = true;
            }
        }

        private void add_book_autor_name_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_book_name_textbox.Enabled = true;
        }

        private void add_book_name_textbox_TextChanged(object sender, EventArgs e)
        {
            book_year_textbox.Enabled = true;
        }
        private void book_year_textbox_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void del_book_name_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UP_autor_name.Enabled = true;
            new_year_book_texbox.Enabled = true;
            button5.Enabled = true;
        }

        private void UP_autor_name_TextChanged(object sender, EventArgs e)
        {
            button6.Enabled = true;
        }

        private void new_year_book_texbox_TextChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }
    }
}

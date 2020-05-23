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
    public partial class Autors : Form
    {
        public Autors()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void button_back_Click(object sender, EventArgs e)
        {
            Operations c = new Operations();
            Hide();
            c.ShowDialog();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Autors d = new Autors();
            Hide();
            d.ShowDialog();
        }

        private void button_add_new_autor_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=N354;Initial Catalog=Lib;Persist Security Info=False;User ID=sa;Password=Sa159753";
            try
            {
                string sqlExpression = "INSERT INTO Autor (name) VALUES('" + New_autor_name.Text.ToString() + "');";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                label_ADD.Visible = true;             
            }
            catch (Exception)
            {
                label_ADD.BackColor = System.Drawing.Color.OrangeRed;
                label_ADD.Text = "Ошибка";
                label_ADD.Visible = true;
            }
        }

        private void button_del_autor_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=N354;Initial Catalog=Lib;Persist Security Info=False;User ID=sa;Password=Sa159753";
            try
            {
                string sqlExpression = "DELETE FROM Autor WHERE ID =" + del_autor_name.SelectedValue.ToString() + ";";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
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
            button5.Enabled = false;
        }

        private void button_edit_autor_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=N354;Initial Catalog=Lib;Persist Security Info=False;User ID=sa;Password=Sa159753";
            try
            {
                if (button5.Enabled == false)
                {
                    label_edit.BackColor = System.Drawing.Color.OrangeRed;
                    label_edit.Text = "Ошибка";
                    label_edit.Visible = true;
                }
                else
                {
                    string sqlExpression = "UPDATE Autor SET name = '" + UP_autor_name.Text.ToString() + "'" + "WHERE name ='" + del_autor_name.Text + "'";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    label_edit.Visible = true;
                }
            }
            catch (Exception)
            {
                label_edit.BackColor = System.Drawing.Color.OrangeRed;
                label_edit.Text = "Ошибка";
                label_edit.Visible = true;
            }
        }

        private void New_autor_name_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void del_autor_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void UP_autor_name_TextChanged(object sender, EventArgs e)
        {
            button6.Enabled = true;
        }
    }
}

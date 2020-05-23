using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Библиотека
{
    public partial class Operations : Form
    {
        public Operations()
        {
            InitializeComponent();
        }
        private void button_autors_Click(object sender, EventArgs e)
        {
            Autors b = new Autors();
            Hide();
            b.Show();
        }

        private void button_books_Click(object sender, EventArgs e)
        {
            Books f = new Books();
            Hide();
            f.Show();
        }

        private void button_readers_Click(object sender, EventArgs e)
        {
            Readers i = new Readers();
            Hide();
            i.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

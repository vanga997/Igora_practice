using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeIgora
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (log.Text == "" || pas.Text == "")
            {
                MessageBox.Show("Введите логин и/или пароль!", "Внимание!");
            }
            else if (log.Text == "Admin" || pas.Text == "Admin")
            {
                MessageBox.Show(log.Text, pas.Text);
                this.Hide();
                Menu newMenu = new Menu();
                newMenu.Show();
            }
            else if (log.Text == "User" || pas.Text == "User")
            {
                this.Hide();
                MenuUser menuUser = new MenuUser();
                menuUser.Show();
            }
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_TextChanged(object sender, EventArgs e)
        {
            //log.Text = 
        }

        private void pas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

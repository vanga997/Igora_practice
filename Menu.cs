using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeIgora
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth newAuth = new Auth();
            newAuth.Show();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client newClient = new Client();
            newClient.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee newEmployee = new Employee();
            newEmployee.Show();
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            this.Hide();
            Request newRequest = new Request();
            newRequest.Show();
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service newService = new Service();
            newService.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            this.Hide();
            History newHistory = new History();
            newHistory.Show();
        }
    }
}

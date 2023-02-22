using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticeIgora
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.igoraDataSet);

        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.igoraDataSet.client);

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu newMenu = new Menu();
            newMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }
    }
}

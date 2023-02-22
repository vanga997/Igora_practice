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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.igoraDataSet);

        }

        private void Service_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet.service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.igoraDataSet.service);

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu newMenu = new Menu();
            newMenu.Show();
        }
    }
}

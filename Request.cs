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
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        private void requestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.igoraDataSet);

        }

        private void Request_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "igoraDataSet.request". При необходимости она может быть перемещена или удалена.
            this.requestTableAdapter.Fill(this.igoraDataSet.request);

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu newMenu = new Menu();
            newMenu.Show();
        }

        private void requestDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

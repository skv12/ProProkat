using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProProkat
{
    public partial class OrdersSubForm : Form
    {
        public OrdersSubForm()
        {
            InitializeComponent();
            zapis();
        }
        public void zapis()
        {
            pp_dbEntities or = new pp_dbEntities();
            dataGridView1.DataSource = or.orders.ToList<orders>();
            dataGridView1.Columns[0].HeaderText = "ФИО клиента";
            dataGridView1.Columns[1].HeaderText = "Статус";
            dataGridView1.Columns[2].HeaderText = "Дата заказа";
            dataGridView1.Columns[3].HeaderText = "Срок";

            for (int i = 4; i <= 5; i++) { dataGridView1.Columns[i].Visible = false; }
        }
        private Form add_form;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            zapis();
        }
    }
}

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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form use_form;
        private void BtnClientList_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();

            if (use_form != null)
            {
                use_form.Close();
            }
            use_form = new ClientsSubForm();
            use_form.TopLevel = false;
            use_form.Dock = DockStyle.Fill;
            this.panel.Controls.Add(use_form);
            use_form.Show();
        }

        private void BtnOrderList_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();

            if (use_form != null)
            {
                use_form.Close();
            }
            use_form = new OrdersSubForm();
            use_form.TopLevel = false;
            use_form.Dock = DockStyle.Fill;
            this.panel.Controls.Add(use_form);
            use_form.Show();
        }

        private void BtnDiskList_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();

            if (use_form != null)
            {
                use_form.Close();
            }
            use_form = new DisksSubForm();
            use_form.TopLevel = false;
            use_form.Dock = DockStyle.Fill;
            this.panel.Controls.Add(use_form);
            use_form.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            Form show_form = new AddOrderForm();
            show_form.ShowDialog();
        }

        private void BtnCreateReport_Click(object sender, EventArgs e)
        {
            Form show_form = new CreateReportForm();
            show_form.ShowDialog();
        }
    }
}

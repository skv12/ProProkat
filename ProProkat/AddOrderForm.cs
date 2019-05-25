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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
            this.panel.Controls.Clear();
            form_activated = new AddClientForm();
            form_activated.FormBorderStyle = 0;
            form_activated.TopLevel = false;
            form_activated.Dock = DockStyle.Fill;
            this.panel.Controls.Add(form_activated);
            form_activated.Show();
            this.panel.Enabled = false;
        }
        private Form form_activated;
        private void chkNewClient_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewClient.Checked)
                this.panel.Enabled = true;
            else
                this.panel.Enabled = false;
        }
    }
}

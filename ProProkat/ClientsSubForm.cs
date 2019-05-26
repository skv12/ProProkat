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
    public partial class ClientsSubForm : Form
    {
        public ClientsSubForm()
        {
            InitializeComponent();
            zapis();
        }
        public void zapis()
        {
            pp_dbEntities c = new pp_dbEntities();
            dataGridView1.DataSource = c.clients.ToList<clients>();
            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "Адрес";
            dataGridView1.Columns[2].HeaderText = "Контактный телефон";
            dataGridView1.Columns[3].HeaderText = "ЧС";
            dataGridView1.Columns[4].Visible = false; 
        }
        private Form add_form;

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            add_form = new AddClientForm();
            add_form.ShowDialog();
            zapis();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pp_dbEntities db = new pp_dbEntities();
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            clients cl = db.clients.Find(id);

            AddClientForm edit_form = new AddClientForm();
            edit_form.txtBoxname.Text = cl.fullname;
            edit_form.txtboxAddress.Text = cl.address;
            edit_form.txtboxphone.Text = cl.contact;
            if (cl.blackliststatus == 1)
                edit_form.chkbxBL.Checked = true;
            else
                edit_form.chkbxBL.Checked = false;

           
            edit_form.ShowDialog();
            zapis();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            pp_dbEntities db = new pp_dbEntities();
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            clients delete_item = db.clients.Find(id);
            db.clients.Remove(delete_item);
            db.SaveChanges();
            zapis();
        }
    }
}

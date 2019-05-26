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
            ClientForm();
            fillchkbox();
        }




        private Form form_activated;
        public void ClientForm() // Форма с добавление клиентов
        {
            this.panel.Controls.Clear();
            AddClientForm form_activated = new AddClientForm();
            form_activated.FormBorderStyle = 0;
            form_activated.TopLevel = false;
            form_activated.Dock = DockStyle.Fill;
            this.panel.Controls.Add(form_activated);
            form_activated.chkModal = true;
            form_activated.Show();
            this.panel.Enabled = false;
        }


        public void fillchkbox() // Заполнение комбобокса данными из базы данных
        {
            pp_dbEntities db = new pp_dbEntities();
            cmbxClient.DataSource = db.clients.ToList<clients>();
            cmbxClient.ValueMember = "Id";
            cmbxClient.DisplayMember = "fullname";
            clientcheck();


            cmbxDisk.DataSource = db.movies.ToList<movies>();
            cmbxDisk.ValueMember = "Id";
            cmbxDisk.DisplayMember = "name";
        }


        private void chkNewClient_CheckedChanged(object sender, EventArgs e) // Включения/выключение видимости формы добавления клиента
        {
            if (chkNewClient.Checked)
                this.panel.Enabled = true;
            else
                this.panel.Enabled = false;
        }

        private void cmbxClient_SelectedIndexChanged(object sender, EventArgs e) // Изменения при выборе клиента из combobox
        {
            clientcheck();
        }

        private void clientcheck() // Проверка клиента на наличие в черном списке, вывод его контактных данных рядом с его именем.
        {
            pp_dbEntities db = new pp_dbEntities();
            int ID = Convert.ToInt32(cmbxClient.SelectedValue.ToString());
            clients cl = db.clients.Where(c => c.id == ID).FirstOrDefault();
            lblcontact.Text = cl.contact.ToString();

            if (cl.blackliststatus == 1)
            {
                lblbl.Text = "Клиент находится в черном списке";
                btnAddOrder.Visible = false;
                //BeginInvoke(new Action(() => cmbxClient.Text = ""));
            }
            else
            {
                btnAddOrder.Visible = true;
                lblbl.Text = "";
            }
        }

        private void btnAddDisk_Click(object sender, EventArgs e) // Добавление дисков в заказ
        {
            pp_dbEntities db = new pp_dbEntities();
            movies mv = db.movies.Where(c => c.name == cmbxDisk.Text).FirstOrDefault();
            int cnt = Convert.ToInt32((txtboxDiskCount.Text));
            if (mv.count < cnt)
                MessageBox.Show("Сейчас доступно только " + mv.count + " дисков.");
            else
            {
                mv.count = mv.count - cnt;
                db.Entry(mv).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
    }
}

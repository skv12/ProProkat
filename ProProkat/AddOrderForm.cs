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


        public void fillchkbox() // Заполнение комбобоксов данными из бд и время.
        {
            pp_dbEntities db = new pp_dbEntities();
            cmbxClient.DataSource = db.clients.ToList<clients>();
            cmbxClient.ValueMember = "Id";
            cmbxClient.DisplayMember = "fullname";
            clientcheck();

            cmbxDisk.DataSource = db.movies.ToList<movies>();
            cmbxDisk.ValueMember = "Id";
            cmbxDisk.DisplayMember = "name";

 
            lblTime.Text = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");
        }


        public void chkNewClient_CheckedChanged(object sender, EventArgs e) // Включения/выключение видимости формы добавления клиента
        {
            if (chkNewClient.Checked)
                this.panel.Enabled = true;
            else
                this.panel.Enabled = false;
        }

        public void cmbxClient_SelectedIndexChanged(object sender, EventArgs e) // Изменения при выборе клиента из combobox
        {
            clientcheck();
        }

        public void clientcheck() // Проверка клиента на наличие в черном списке, вывод его контактных данных рядом с его именем.
        {
            pp_dbEntities db = new pp_dbEntities();
            int ID = Convert.ToInt32(cmbxClient.SelectedValue.ToString());
            clients cl = db.clients.Where(c => c.id == ID).FirstOrDefault();
            lblcontact.Text = cl.contact.ToString();

            if (cl.blackliststatus == 1)
            {
                lblbl.Text = "Клиент находится в черном списке";
                btnAddOrder.Visible = false;
            }
            else
            {
                btnAddOrder.Visible = true;
                lblbl.Text = "";
            }
        }

        private int[] DiskList = new int[10000];
        private int[] DiskCount = new int[10000];
        private int i = 0;
        private int price = 0;
        public void btnAddDisk_Click(object sender, EventArgs e) // Добавление дисков в заказ
        {
            //int price = 0;
            pp_dbEntities db = new pp_dbEntities();
            movies mv = db.movies.Where(c => c.name == cmbxDisk.Text).FirstOrDefault();
            int cnt = Convert.ToInt32((txtboxDiskCount.Text));

            if (mv.count < cnt)
            {
                lbldskcount.Visible = false;
                label8.Text = "Закажите не более " + lbldskcount.Text + " дисков"; 
            }
            else
            {
                mv.count = mv.count - cnt;
                db.Entry(mv).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                int ID = Convert.ToInt32(cmbxDisk.SelectedValue.ToString());
                movies dsk = db.movies.Where(c => c.Id == ID).FirstOrDefault();
                lbldskcount.Text = dsk.count.ToString();
                lbldskcount.Visible = true;
                label8.Text = "Дисков в наличии:";
                bool UsheEst = false;
                for(int j = 0; j < i; j++)
                {
                    if (DiskList[j] == dsk.Id)
                    {
                        DiskCount[j] = DiskCount[j] + cnt;
                        UsheEst = true;
                        price = price + dsk.price * cnt;
                        break;
                    }
                }
                if (!UsheEst)
                {
                    DiskList[i] = dsk.Id;
                    DiskCount[i] = cnt;
                    price = price + dsk.price * cnt;
                    i++;
                }
            }
            lblDeposit.Text = price.ToString();
            lblPrice.Text = (price / 5).ToString();
        }

        private void cmbxClient_KeyPress(object sender, KeyPressEventArgs e) // Живой поиск в cmbxClient (нашел в интернете, ниче не понял o_O )
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
        }

        private void cmbxDisk_KeyPress(object sender, KeyPressEventArgs e) // То же самое, но по дискам
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
        }

        private void cmbxClient_Click(object sender, EventArgs e) // При клике на комбобокс сразу появляются варианты.
        {
            ((ComboBox)(sender)).DroppedDown = true;
        }

        private void cmbxDisk_Click(object sender, EventArgs e) // То же самое, но по дискам
        {
            ((ComboBox)(sender)).DroppedDown = true;
        }

        private void AddOrderForm_Activated(object sender, EventArgs e) //Обновление combobox'ов при добавлении клиента
        {
            fillchkbox();
            chkNewClient.Checked = false;
            pp_dbEntities db = new pp_dbEntities();
            int intIdt = db.clients.Max(u => u.id);  //Поиск клиента с наибольшим ID
            clients cl = db.clients.Where(c => c.id == intIdt).FirstOrDefault();
            cmbxClient.Text = cl.fullname.ToString();
        }

        private void cmbxDisk_SelectedIndexChanged(object sender, EventArgs e) //Показывает кол-во доступных дисков в label'ах, при выборе из combobox'а.
        {
            pp_dbEntities db = new pp_dbEntities();
            int ID = Convert.ToInt32(cmbxDisk.SelectedValue.ToString());
            movies dsk = db.movies.Where(c => c.Id == ID).FirstOrDefault();
            lbldskcount.Text = dsk.count.ToString();
            lbldskcount.Visible = true;
            label8.Text = "Дисков в наличии:";
        }


        
        private void btnAddOrder_Click(object sender, EventArgs e) // Добавление заказа
        {
            using (pp_dbEntities db = new pp_dbEntities())
            {
                string SpisokDiskov = "";
                for (int j = 0; j < i; j++)
                    SpisokDiskov = SpisokDiskov + DiskList[j].ToString() + " " + DiskCount[j].ToString() + " ";
                 
                orders ord = new orders
                {
                    client = cmbxClient.Text,
                    status = "1",
                    date = DateTime.Now,
                    rent = DateTime.Now.AddDays(Convert.ToInt32(txtboxRent.Text)),
                    disklist = SpisokDiskov,
                    deposit =Convert.ToString(price),
                };
                try
                {
                    db.orders.Add(ord);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return;
                }
            }
            this.Close();
        } 

        private void txtboxRent_TextChanged(object sender, EventArgs e) // Вывод даты ренты при вводе количества дней
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Now.AddDays(Convert.ToInt32(txtboxRent.Text));
            lblRent.Text = date1.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            btnAddOrder.Name = "Закрыть заказ";
        }
    }
}


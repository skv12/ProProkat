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
            cmbxClient.DataSource = db.clients.OrderBy(c => c.fullname).ToList<clients>();
            cmbxClient.ValueMember = "Id";
            cmbxClient.DisplayMember = "fullname";
            if(cmbxClient.Items == null)
            { 
                clientcheck();
            }

            cmbxDisk.DataSource = db.movies.OrderBy(c => c.name).ToList<movies>();
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
            lblAddress.Text = cl.address.ToString();
            if (cl.blackliststatus == 1)
            {
                if (txtboxRent.Text != "")
                {
                    if (Convert.ToInt32(txtboxRent.Text) > 14)
                        lblbl.Text = "Клиент находится в черном списке" + '\n' + "Максимальный срок заказа 14 дней";
                    else
                        lblbl.Text = "Клиент находится в черном списке";
                }
                else
                    lblbl.Text = "Клиент находится в черном списке";
                btnAddOrder.Visible = false;
                btnAddDisk.Visible = false;
            }
            else
            {
                if (txtboxRent.Text != "")
                {
                    if (Convert.ToInt32(txtboxRent.Text) > 14)
                    {
                        btnAddOrder.Visible = false;
                        lblbl.Text = "Максимальный срок заказа 14 дней";
                    }
                    else
                    {
                        lblbl.Text = "";
                        btnAddOrder.Visible = true;
                        btnAddDisk.Visible = true;
                    }
                }
                else
                {
                    lblbl.Text = "";
                    btnAddOrder.Visible = true;
                    btnAddDisk.Visible = true;
                }
            }
        }

        private int[] DiskList = new int[10000];
        private int[] DiskCount = new int[10000];
        private int i = 0;
        private double price = 0;
        private bool dobavlen = false;
        private string SpisokDiskov;
        public void btnAddDisk_Click(object sender, EventArgs e) // Добавление дисков в заказ
        {
            if (txtboxDiskCount.Text == "" || Convert.ToInt32(txtboxDiskCount.Text) == 0)
                lbldsk.Visible = true;
            else
            {
                lbldsklst.Text = "";
                dobavlen = true;
                lbldsk.Visible = false;
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
                    for (int j = 0; j < i; j++)
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
                if (txtboxRent.Text != "")
                    lblPrice.Text = (price / 20 * Convert.ToDouble(txtboxRent.Text)).ToString();
                else
                    lblPrice.Text = (price / 20).ToString();
                    lblDeposit.Text = price.ToString();

                SpisokDiskov = "";
                for (int j = 0; j < i; j++)
                    SpisokDiskov = SpisokDiskov + DiskList[j].ToString() + " " + DiskCount[j].ToString() + " ";
                string dl = "";
                string s = SpisokDiskov;
                bool a = true;
                int id3 = 0;
                String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    int[] array = words[i].Where(x => char.IsNumber(x)).Select(x => x - 48).ToArray();
                    for (int j = 0; j < array.Length; j++)
                        id3 = id3 * 10 + array[j];
                    if (a)
                    {
                        dl = "";
                        movies mv3 = db.movies.Where(c => c.Id == id3).FirstOrDefault();
                        dl = dl + mv3.name.ToString() + " ";
                        id3 = 0;
                        a = false;
                    }
                    else
                    {
                        dl = dl + id3.ToString() + " шт ";
                        id3 = 0;
                        a = true;
                        lbldsklst.Text = lbldsklst.Text + '\n' + dl;
                    }
                }
            }
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
            try
            {
                int intIdt = db.clients.Max(u => u.id);  //Поиск клиента с наибольшим ID
                clients cl = db.clients.Where(c => c.id == intIdt).FirstOrDefault();
                cmbxClient.Text = cl.fullname.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
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


        private bool orderadded = false;
        private void btnAddOrder_Click(object sender, EventArgs e) // Добавление заказа
        {
            if (cmbxClient.Text == "" || lblRent.Text == "" || !dobavlen)
            {
                lblbl.Text = '\n' + "Все поля обязательны к заполнению";
            }
            else
            {
                using (pp_dbEntities db = new pp_dbEntities())
                {

                    orders ord = new orders
                    {
                        client = cmbxClient.Text,
                        status = "1",
                        date = DateTime.Now,
                        rent = DateTime.Now.AddDays(Convert.ToInt32(txtboxRent.Text)),
                        disklist = SpisokDiskov,
                        deposit = Convert.ToString(price),
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
                orderadded = true;
                this.Close();
            }
        } 

        private void txtboxRent_TextChanged(object sender, EventArgs e) // Вывод даты ренты при вводе количества дней и стоимости ренты.
        {   
            DateTime date1 = new DateTime();
            if (txtboxRent.Text != "")
            {
                date1 = DateTime.Now.AddDays(Convert.ToInt32(txtboxRent.Text));
                lblRent.Text = date1.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");
                lblPrice.Text = (price / 20 * Convert.ToDouble(txtboxRent.Text)).ToString();
                pp_dbEntities db = new pp_dbEntities();
                int ID = Convert.ToInt32(cmbxClient.SelectedValue.ToString());
                clients cl = db.clients.Where(c => c.id == ID).FirstOrDefault();

                if (Convert.ToInt32(txtboxRent.Text) > 14)
                {
                    btnAddOrder.Visible = false;
                    if (cl.blackliststatus == 0)
                    {
                        lblbl.Text = "Максимальный срок заказа 14 дней";
                        btnAddDisk.Visible = true;
                    }
                    else
                    {
                        lblbl.Text = "Клиент находится в черном списке" + '\n' + "Максимальный срок заказа 14 дней";
                        btnAddDisk.Visible = false;
                    }
                }
                else
                {

                    if (cl.blackliststatus == 1)
                    {
                        lblbl.Text = "Клиент находится в черном списке";
                        btnAddDisk.Visible = false;
                    }
                    else
                    {
                        btnAddDisk.Visible = true;
                        btnAddOrder.Visible = true;
                        lblbl.Text = "";
                    }
                }
            }
            else
                lblPrice.Text = (price / 20).ToString();
            
        }

        private void txtboxDiskCount_KeyPress(object sender, KeyPressEventArgs e) // Ограничения ввода в текстобокс(только числа)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtboxRent_KeyPress(object sender, KeyPressEventArgs e) // Ограничения ввода в текстобокс(только числа)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void AddOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SpisokDiskov != null && !orderadded)
            { 
                pp_dbEntities db = new pp_dbEntities();
                string s = SpisokDiskov;
                int id1 = 0;
                int id2 = 0;
                String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length - 1; i += 2)
                {
                    int[] array = words[i].Where(x => char.IsNumber(x)).Select(x => x - 48).ToArray();
                    int[] array2 = words[i + 1].Where(x => char.IsNumber(x)).Select(x => x - 48).ToArray();
                    for (int j = 0; j < array.Length; j++)
                        id1 = id1 * 10 + array[j];
                    for (int j = 0; j < array2.Length; j++)
                        id2 = id2 * 10 + array2[j];
                    movies mv = db.movies.Where(c => c.Id == id1).FirstOrDefault();
                    mv.count += id2;
                    db.Entry(mv).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}


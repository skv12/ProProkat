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
    public partial class AddClientForm : Form
    {
        public string name2;
        public bool add_or_edit = false;
        public bool chkModal = false;
        public AddClientForm()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (pp_dbEntities db = new pp_dbEntities())
            {
                SByte chk = 0;
                if (chkbxBL.Checked) 
                    chk = 1;
                
                clients cl = new clients
                {
                    fullname = txtBoxname.Text,
                    address = txtboxAddress.Text,
                    contact = txtboxphone.Text,
                    blackliststatus = chk,
                };
                try
                {
                    if (!add_or_edit)
                    {
                        db.clients.Add(cl);
                        db.SaveChanges();
                    }
                    else
                    {

                        clients cl2 = db.clients.Where(c => c.fullname == name2).FirstOrDefault();
                        cl2.fullname = txtBoxname.Text;
                        cl2.address = txtboxAddress.Text;
                        cl2.contact = txtboxphone.Text;
                        if (chkbxBL.Checked)
                            cl2.blackliststatus = 1;
                        else
                            cl2.blackliststatus = 0;

                        db.Entry(cl2).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }
            if (!chkModal)
                this.Close();
            else
            {
                MessageBox.Show("Клиент добавлен");
            }
        }
        private void AddClientForm_Load(object sender, EventArgs e)
        {
            if (txtBoxname.Text != "")
            {
                name2 = txtBoxname.Text;
                add_or_edit = true;
                btnAdd.Text = "Редакт.";
                this.Text = "Редактирование клиента";

            }
        }
    }
}

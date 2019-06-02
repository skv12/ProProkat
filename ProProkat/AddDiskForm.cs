using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProProkat
{
    public partial class AddDiskForm : Form
    {

        public string name2;
        public bool add_or_edit = false;
        public AddDiskForm()
        {
            InitializeComponent();
            fillchkbox();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtboxName.Text == "" || txtboxPrice.Text == "" || txtboxCount.Text == "")
                MessageBox.Show("ЭЭЭ, ЗАПОЛНИ!");
            else
            {
                using (pp_dbEntities db = new pp_dbEntities())
                {

                    movies mv = new movies
                    {
                        name = txtboxName.Text,
                        synopsis = rTxtBoxSynopsis.Text,
                        genres = cmbxGenre.Text,
                        director = txtboxDirector.Text,
                        year = txtboxYear.Text,
                        agerating = cmbxAgerating.Text,
                        country = cmbxCounrty.Text,
                        price = Convert.ToInt32(txtboxPrice.Text),
                        count = Convert.ToInt32(txtboxCount.Text),
                    };
                    try
                    {
                        if (!add_or_edit)
                        {
                            db.movies.Add(mv);
                            db.SaveChanges();
                        }
                        else
                        {
                            movies mv2 = db.movies.Where(c => c.name == name2).FirstOrDefault();
                            mv2.name = txtboxName.Text;
                            mv2.synopsis = rTxtBoxSynopsis.Text;
                            mv2.genres = cmbxGenre.Text;
                            mv2.director = txtboxDirector.Text;
                            mv2.year = txtboxYear.Text;
                            mv2.agerating = cmbxAgerating.Text;
                            mv2.country = cmbxCounrty.Text;
                            mv2.price = Convert.ToInt32(txtboxPrice.Text);
                            mv2.count = Convert.ToInt32(txtboxCount.Text);

                            db.Entry(mv2).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void AddDiskForm_Load(object sender, EventArgs e)
        {
            if (txtboxName.Text != "")
            {
                name2 = txtboxName.Text;
                add_or_edit = true;
                btnAdd.Text = "Редакт.";
                this.Text = "Редактирование диска";
            }
        }

        public void fillchkbox() // Заполнение комбобокса данными из базы данных
        {
            pp_dbEntities db = new pp_dbEntities();
            cmbxGenre.DataSource = db.genres.ToList<genres>();
            cmbxGenre.ValueMember = "Id";
            cmbxGenre.DisplayMember = "name";
            
            cmbxAgerating.DataSource = db.agerating.ToList<agerating>();
            cmbxAgerating.ValueMember = "Id";
            cmbxAgerating.DisplayMember = "name";

            cmbxCounrty.DataSource = db.country.ToList<country>();
            cmbxCounrty.ValueMember = "Id";
            cmbxCounrty.DisplayMember = "name";
        }

        private void cmbxGenre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbxCounrty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbxAgerating_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbxGenre_Click(object sender, EventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
        }

        private void cmbxCounrty_Click(object sender, EventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
        }

        private void cmbxAgerating_Click(object sender, EventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
        }

        private void LnkNewGenre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewDiskData edit_form = new AddNewDiskData();
            edit_form.lblData.Text = "Жанр";
            edit_form.ShowDialog();
            fillchkbox();
        }

        private void LnkNewCountry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewDiskData edit_form = new AddNewDiskData();
            edit_form.lblData.Text = "Страна";
            edit_form.ShowDialog();
            fillchkbox();
        }

        private void LnkNewAgeRating_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewDiskData edit_form = new AddNewDiskData();
            edit_form.lblData.Text = "Возрастной рейтинг";
            edit_form.ShowDialog();
            fillchkbox();
        }

        private void txtboxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtboxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}

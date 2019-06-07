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
    public partial class DisksSubForm : Form
    {
        public DisksSubForm()
        {
            InitializeComponent();
            zapis();
            fillchkbox();
        }
        public void zapis()
        {
            pp_dbEntities db = new pp_dbEntities();
            var Movies = db.movies.OrderBy(c => c.name);
            dataGridView1.DataSource = Movies.ToList<movies>();
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Количество";
            dataGridView1.Columns[2].HeaderText = "Цена";
            for (int i = 3; i <= 9; i++)
                dataGridView1.Columns[i].Visible = false;
        }


        private Form add_form;
        private void btnAddDisk_Click(object sender, EventArgs e)
        {
            add_form = new AddDiskForm();
            add_form.ShowDialog();
            zapis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zapis();
        }

        private void btnRemoveDisk_Click(object sender, EventArgs e)
        {
            pp_dbEntities db = new pp_dbEntities();
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
            movies delete_item = db.movies.Find(id);
            db.movies.Remove(delete_item);
            db.SaveChanges();
            zapis();
        }

        private void DisksSubForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pp_dbEntities db = new pp_dbEntities();
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
            movies mv = db.movies.Find(id);

            AddDiskForm edit_form = new AddDiskForm();
            edit_form.txtboxName.Text = mv.name;
            edit_form.rTxtBoxSynopsis.Text = mv.synopsis;
            edit_form.cmbxGenre.Text = mv.genres;
            edit_form.txtboxDirector.Text = mv.director;
            edit_form.txtboxYear.Text = mv.year;
            edit_form.cmbxAgerating.Text = mv.agerating;
            edit_form.cmbxCounrty.Text = mv.country;
            edit_form.txtboxPrice.Text = Convert.ToString(mv.price);
            edit_form.txtboxCount.Text = Convert.ToString(mv.count);

            edit_form.ShowDialog();
            zapis();
        }
        private void btnSearchDisk_Click(object sender, EventArgs e)
        {

            //Form search_form = new DiskSearch();
            //search_form.ShowDialog();
            //zapis();



            /*
            ListData ds = new ListData();
            List<movies> mv = ds.mv;
            pp_dbEntities db = new pp_dbEntities();
            var Movies = db.movies.OrderBy(c => c.name);
            dataGridView1.DataSource = mv;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Количество";
            dataGridView1.Columns[2].HeaderText = "Цена";
            for (int i = 3; i <= 9; i++)
                dataGridView1.Columns[i].Visible = false;
            */

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            btnSearch.Visible = true;
            cmbxCounrty.Visible = true;
            cmbxPageRating.Visible = true;
            cmbxGenre.Visible = true;
            tbSearchDirector.Visible = true;
            tbSearchName.Visible = true;
            tbSearchYear.Visible = true;
        }
        public List<movies> mv;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pp_dbEntities db = new pp_dbEntities();

            if (cmbxPageRating.Text != "" && cmbxPageRating.Text != null)
            {
                if (tbSearchYear.Text != "" && tbSearchYear.Text != null)
                {
                    mv = db.movies.
                    Where<movies>(x => x.name.Contains(tbSearchName.Text)).
                    Where<movies>(x => x.agerating == cmbxPageRating.Text).
                    Where<movies>(x => x.genres.Contains(cmbxGenre.Text)).
                    Where<movies>(x => x.director.Contains(tbSearchDirector.Text)).
                    Where<movies>(x => x.year.Contains(tbSearchYear.Text)).
                    Where<movies>(x => x.country.Contains(cmbxCounrty.Text)).ToList();
                    zapis2(mv);
                }
                else
                {
                    mv = db.movies.
                       Where<movies>(x => x.name.Contains(tbSearchName.Text)).
                       Where<movies>(x => x.agerating == cmbxPageRating.Text).
                       Where<movies>(x => x.genres.Contains(cmbxGenre.Text)).
                       Where<movies>(x => x.director.Contains(tbSearchDirector.Text)).
                       Where<movies>(x => x.country.Contains(cmbxCounrty.Text)).ToList();
                    zapis2(mv);
                }
            }
            else
            {
                if (tbSearchYear.Text != "" && tbSearchYear.Text != null)
                {
                    mv = db.movies.
                   Where<movies>(x => x.name.Contains(tbSearchName.Text)).
                   Where<movies>(x => x.genres.Contains(cmbxGenre.Text)).
                   Where<movies>(x => x.year.Contains(tbSearchYear.Text)).
                   Where<movies>(x => x.director.Contains(tbSearchDirector.Text)).
                   Where<movies>(x => x.country.Contains(cmbxCounrty.Text)).ToList();
                    zapis2(mv);
                }
                else
                {
                    mv = db.movies.
                       Where<movies>(x => x.name.Contains(tbSearchName.Text)).
                       Where<movies>(x => x.genres.Contains(cmbxGenre.Text)).
                       Where<movies>(x => x.director.Contains(tbSearchDirector.Text)).
                       Where<movies>(x => x.country.Contains(cmbxCounrty.Text)).ToList();
                    zapis2(mv);
                }
            }
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btnSearch.Visible = false;
            cmbxCounrty.Visible = false;
            cmbxPageRating.Visible = false;
            cmbxGenre.Visible = false;
            tbSearchDirector.Visible = false;
            tbSearchName.Visible = false;
            tbSearchYear.Visible = false;
            
            cmbxCounrty.SelectedValue = "";
            cmbxPageRating.SelectedValue = "";
            cmbxGenre.SelectedValue = "";
            tbSearchDirector.Text = "";
            tbSearchName.Text = "";
            tbSearchYear.Text = "";
        }
        public void fillchkbox() // Заполнение комбобоксов данными из бд и время.
        {
            pp_dbEntities db = new pp_dbEntities();
            cmbxCounrty.DataSource = db.country.OrderBy(c => c.name).ToList<country>();
            cmbxCounrty.ValueMember = "Id";
            cmbxCounrty.DisplayMember = "name";

            cmbxGenre.DataSource = db.genres.OrderBy(c => c.name).ToList<genres>();
            cmbxGenre.ValueMember = "Id";
            cmbxGenre.DisplayMember = "name";

            cmbxPageRating.DataSource = db.agerating.OrderBy(c => c.name).ToList<agerating>();
            cmbxPageRating.ValueMember = "Id";
            cmbxPageRating.DisplayMember = "name";

            cmbxCounrty.SelectedValue = "";
            cmbxPageRating.SelectedValue = "";
            cmbxGenre.SelectedValue = "";
        }
        private void zapis2(List<movies> mv)
        {
            pp_dbEntities db = new pp_dbEntities();
            var Movies = db.movies.OrderBy(c => c.name);
            dataGridView1.DataSource = mv;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Количество";
            dataGridView1.Columns[2].HeaderText = "Цена";
            for (int i = 3; i <= 9; i++)
                dataGridView1.Columns[i].Visible = false;
            this.Refresh();
        }

        private void cmbxGenre_Click(object sender, EventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
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

        private void cmbxPageRating_Click(object sender, EventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
        }

        private void cmbxPageRating_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbxCounrty_Click(object sender, EventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
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
    }
}

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
    public partial class DiskSearch : Form
    {
        public DiskSearch()
        {
            InitializeComponent();
            fillchkbox();
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
                        zapis(mv);
                    }
                    else
                    {
                     mv = db.movies.
                        Where<movies>(x => x.name.Contains(tbSearchName.Text)).
                        Where<movies>(x => x.agerating == cmbxPageRating.Text).
                        Where<movies>(x => x.genres.Contains(cmbxGenre.Text)).
                        Where<movies>(x => x.director.Contains(tbSearchDirector.Text)).
                        Where<movies>(x => x.country.Contains(cmbxCounrty.Text)).ToList();
                        zapis(mv);
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
                        zapis(mv);
                }
                    else
                    {
                     mv = db.movies.
                        Where<movies>(x => x.name.Contains(tbSearchName.Text)).
                        Where<movies>(x => x.genres.Contains(cmbxGenre.Text)).
                        Where<movies>(x => x.director.Contains(tbSearchDirector.Text)).
                        Where<movies>(x => x.country.Contains(cmbxCounrty.Text)).ToList();
                        zapis(mv);
                    }
                }
            //ListData dsf = new ListData();
            //dsf.mv = mv;
            //this.Close();
        }
        
            private void zapis(List<movies> mv)
        {
            pp_dbEntities db = new pp_dbEntities();
            var Movies = db.movies.OrderBy(c => c.name);
            dataGridView1.DataSource = mv;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Количество";
            dataGridView1.Columns[2].HeaderText = "Цена";
            for (int i = 3; i <= 9; i++)
                dataGridView1.Columns[i].Visible = false;
            //
            //asd.Refresh();
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

        private void cmbxGenre_Click(object sender, EventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
        }

        private void cmbxPageRating_Click(object sender, EventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
        }

        private void cmbxCounrty_Click(object sender, EventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
        }
    }
}

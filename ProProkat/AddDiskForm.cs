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
        public bool add_or_edit = false;
        public AddDiskForm()
        {
            
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (pp_dbEntities db = new pp_dbEntities())
            {
                movies mv = new movies
                {
                    name = txtboxName.Text,
                    synopsis = rTxtBoxSynopsis.Text,
                    genres = txtboxGenre.Text,
                    director = txtboxDirector.Text,
                    year = txtboxYear.Text,
                    agerating = txtboxAgeRating.Text,
                    country = txtboxCountry.Text,
                    price = Convert.ToInt32(txtboxPrice.Text),
                    count = Convert.ToInt32(txtboxCount.Text),
                };
                try
                {
                    if (add_or_edit)
                    {
                        db.movies.Add(mv);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Entry<movies>(mv).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                catch (Exception ex) {
                    return;
                }
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void AddDiskForm_Load(object sender, EventArgs e)
        {
            if (txtboxName.Text != "")
            {
                add_or_edit = true;
                btnAdd.Text = "Редакт.";
                this.Text = "Редактирование диска";
            }
        }
    }
}

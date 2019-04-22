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
    public partial class AddDiskForm : Form
    {
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
                    count = Convert.ToInt32(txtboxCount.Text)
                };
                try
                {
                    db.movies.Add(mv);
                    db.SaveChanges();
                }
                catch (Exception ex) {
                    return;
                }
            }
            this.Close();
            //DisksSubForm z = new DisksSubForm();
            //z.zapis();
            //z = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}

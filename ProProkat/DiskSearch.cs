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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*TableContext db1 = new TableContext();
           db1.Pictures.Include("Authors").Where(x => x.Year.Year==dtPicker.Value.Year).Load();
           dGVPicturesList.DataSource = db1.Pictures.Local.ToBindingList();*/

            //var filter = db.Pictures.Include("Authors").Where(x => x.Name.Contains(tbPicFilter.Text)).Where(x => x.Authors.Name.Contains(tbPicFilter2.Text)).Where(x => x.Year.Year == dtPicker.Value.Year).ToList();
            /*
            pp_dbEntities db = new pp_dbEntities();
            foreach (movies c in db.movies)
            {
                if (tbSearchName.Text != "")
                    var mv = db.movies.Where(c => c.name.Contains(tbSearchName.Text)).ToList();
            }



                if (dtPicFilter.Value.Year == 1753 && dtPicFilter.Value.Month == 01 && dtPicFilter.Value.Day == 01)
            {
                var PicFilter = db.Pictures.Include("Authors").Where(x => x.Name.Contains(tbPicFilter.Text)).Where(x => x.Authors.Name.Contains(tbPicFilter2.Text)).Where(x => x.Status.Status.Contains(cbPicFilter.Text)).ToList();
                dGVPicturesList.DataSource = PicFilter;
            }
            else
            {
                var PicFilter = db.Pictures.Include("Authors").Where(x => x.Name.Contains(tbPicFilter.Text)).Where(x => x.Authors.Name.Contains(tbPicFilter2.Text)).Where(x => x.Status.Status.Contains(cbPicFilter.Text)).Where(x => x.Year.Year <= dtPicFilter.Value.Year).ToList();
                dGVPicturesList.DataSource = PicFilter;
            }
            */
        }
    }
}

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
    public partial class AddNewDiskData : Form
    {
        public AddNewDiskData()
        {
            InitializeComponent();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            pp_dbEntities db = new pp_dbEntities();
            if (txtboxData.Text != "")
            {
                if (lblData.Text == "Жанр")
                {
                    genres gr = new genres
                    {
                        name = txtboxData.Text
                    };
                    db.genres.Add(gr);
                    db.SaveChanges();
                    this.Close();
                }
                else if (lblData.Text == "Страна")
                {
                    country cr = new country
                    {
                        name = txtboxData.Text
                    };
                    db.country.Add(cr);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    agerating ar = new agerating
                    {
                        name = txtboxData.Text
                    };
                    db.agerating.Add(ar);
                    db.SaveChanges();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Поле пустое");
            }
            
        }
    }
}

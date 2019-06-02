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
        private void zapis() {
            pp_dbEntities db = new pp_dbEntities();
            if (lblData.Text == "Жанр")
            {
                dataGridView1.DataSource = db.genres.ToList<genres>();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Жанры";
            }
            else if (lblData.Text == "Страна")
            {
                dataGridView1.DataSource = db.country.ToList<country>();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Страны";
            }
            else
            {
                dataGridView1.DataSource = db.agerating.ToList<agerating>();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Возрастные рейтинги";
            }
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

        private void AddNewDiskData_Load(object sender, EventArgs e)
        {
            zapis();
        }

        private void btnRemoveData_Click(object sender, EventArgs e)
        {
                pp_dbEntities db = new pp_dbEntities();
                if (lblData.Text == "Жанр")
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    genres delete_item = db.genres.Find(id);
                    db.genres.Remove(delete_item);
                    db.SaveChanges();
                    
                }
                else if (lblData.Text == "Страна")
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    country delete_item = db.country.Find(id);
                    db.country.Remove(delete_item);
                    db.SaveChanges();
                }
                else
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    agerating delete_item = db.agerating.Find(id);
                    db.agerating.Remove(delete_item);
                    db.SaveChanges();
                }
            zapis();
        }
    }
}

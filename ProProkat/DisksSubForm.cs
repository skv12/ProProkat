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
        }
        public void zapis()
        {
            listView1.Items.Clear();
            pp_dbEntities db = new pp_dbEntities();
            var movie = db.movies;
            foreach (movies m in movie)
            {
                string[] row = { m.name, Convert.ToString(m.price), Convert.ToString(m.count) };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
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
    }
}

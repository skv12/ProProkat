﻿using System;
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
            Form search_form = new DiskSearch();
            search_form.ShowDialog();
        }
    }
}

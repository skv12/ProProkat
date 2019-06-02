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
    public partial class OrdersSubForm : Form
    {
        public OrdersSubForm()
        {
            InitializeComponent();
            zapis();
        }
        public void zapis()
        {
            pp_dbEntities or = new pp_dbEntities();
            dataGridView1.DataSource = or.orders.ToList<orders>();

            dataGridView1.Columns[0].HeaderText = "ФИО клиента";
            dataGridView1.Columns[1].HeaderText = "Статус";
            dataGridView1.Columns[2].HeaderText = "Дата заказа";
            dataGridView1.Columns[3].HeaderText = "Срок";
            if (chkboxClosedOrder.Checked == true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "0" || dataGridView1.Rows[i].Cells[1].Value.ToString() == "3")
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                }
            }
            else
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "0" || dataGridView1.Rows[i].Cells[1].Value.ToString() == "3")
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
            //for (int i = 4; i <= 5; i++) { dataGridView1.Columns[i].Visible = false; }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            zapis();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pp_dbEntities db = new pp_dbEntities();
            int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            orders or = db.orders.Find(ID);




            string dl = "";
            string s = or.disklist.ToString();
            bool a = true;
            int id3 = 0;
            String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                int[] array = words[i].Where(x => char.IsNumber(x)).Select(x => x - 48).ToArray();
                for (int j = 0; j < array.Length; j++)
                    id3 = id3 * 10 + array[j];
                    if (a)
                    {
                        movies mv = db.movies.Where(c => c.Id == id3).FirstOrDefault();
                        dl = dl + mv.name.ToString() + " ";
                        id3 = 0;
                        a = false;
                    }
                    else 
                    {
                        dl = dl + id3.ToString() + " шт ";
                        id3 = 0;
                        a = true;
                    }
            }



            OrderCloseForm close_form = new OrderCloseForm();
            close_form.lblcl.Text = or.client.ToString();
            close_form.lbldsk.Text = dl.ToString();
            close_form.lbldeposit.Text = or.deposit.ToString();
            close_form.lblrent.Text = or.rent.ToString();
            close_form.lblid.Text = or.id.ToString();
            close_form.ShowDialog();
            zapis();
        }

        private void chkboxClosedOrder_CheckedChanged(object sender, EventArgs e)
        {
            zapis();
        }
    }
}

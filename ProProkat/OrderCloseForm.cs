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
    public partial class OrderCloseForm : Form
    {
        public OrderCloseForm()
        {
            InitializeComponent();
        }
        
        private void btnclose_Click(object sender, EventArgs e)
        {

            int id2 = Convert.ToInt32(lblid.Text.ToString());
            pp_dbEntities db = new pp_dbEntities();
            orders or = db.orders.Where(c => c.id == id2).FirstOrDefault();
            or.closed_date = DateTime.Now;
            or.status = 0.ToString();
            db.Entry(or).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            this.Close();
        }
    }
}

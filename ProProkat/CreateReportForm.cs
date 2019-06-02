using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProProkat
{
    public partial class CreateReportForm : Form
    {
        public CreateReportForm()
        {
            InitializeComponent();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            pp_dbEntities db = new pp_dbEntities();
            string date_from = dateTimePickerFrom.Value.ToShortDateString();
            string date_to = dateTimePickerTo.Value.ToShortDateString();
            MySql.Data.MySqlClient.MySqlParameter df = new MySql.Data.MySqlClient.MySqlParameter("@date_from", date_from);
            MySql.Data.MySqlClient.MySqlParameter dt = new MySql.Data.MySqlClient.MySqlParameter("@date_to", date_to);
            var query = db.Database.SqlQuery<orders>("SELECT * FROM orders WHERE date > @date_from AND date < @date_to AND status = 0", df, dt);

            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Отчет от " + DateTime.Now.ToShortDateString();
            int cell = 2;
            worksheet.Cells[1, 1] = "ID заказа";
            worksheet.Cells[1, 2] = "Клиент";
            foreach (var orders in query)
            {
                worksheet.Cells[cell, 1] = orders.id.ToString();
                worksheet.Cells[cell, 2] = orders.client.ToString();
                cell++;
            }

        }
    }
}

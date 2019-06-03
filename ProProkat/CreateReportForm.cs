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
            var query_closed = db.orders.Where<orders>(f => f.closed_date >= dateTimePickerFrom.Value).Where<orders>(t => t.closed_date <= dateTimePickerTo.Value).Where<orders>(s => s.status == "0");
            var query_active = db.orders.Where<orders>(t => t.date <= dateTimePickerTo.Value).Where<orders>(s => s.status == "1");
            label1.Text = Convert.ToString((dateTimePickerTo.Value - dateTimePickerFrom.Value).TotalHours);
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet closed_sheet = null;
            app.Visible = true;
            closed_sheet = workbook.ActiveSheet;
            closed_sheet.Name = "Закрытые заказы";
            int cell = 3;
            double cash = 0;
            closed_sheet.Cells[1, 1] = "Выполненные заказы";
            closed_sheet.Range[closed_sheet.Cells[1, 1], closed_sheet.Cells[1, 2]].Merge();
            closed_sheet.Cells[2, 1] = "ID заказа";
            closed_sheet.Cells[2, 2] = "Клиент";
            
            Excel.Range cellRange = (Excel.Range)closed_sheet.Cells[1, 1];
            Excel.Range rowRange = cellRange.EntireRow;
            Excel.Range colRange = cellRange.EntireColumn;

            foreach (var orders in query_closed)
            {
                closed_sheet.Cells[cell, 1] = orders.id.ToString();
                closed_sheet.Cells[cell, 2] = orders.client.ToString();
                DateTime a = orders.closed_date.Value;
                DateTime b = orders.date.Value;
                double ddiff = (a-b).TotalHours/24;
                cash += Convert.ToDouble(Convert.ToDouble(orders.deposit) / 20 * ddiff);
                cell++;
            }

            closed_sheet.Cells[cell+1, 1] = "Итого выполнено";
            closed_sheet.Cells[cell+1, 2] = "Заработано";
            closed_sheet.Cells[cell+2, 1] = cell-3;
            closed_sheet.Cells[cell+2, 2] = cash;
            Excel.Range fit_cells = closed_sheet.UsedRange;           
            fit_cells.EntireColumn.AutoFit();
            fit_cells.EntireRow.AutoFit();
            fit_cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fit_cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            Excel.Worksheet active_sheet = null;
            active_sheet = workbook.ActiveSheet;
            active_sheet.Name = "Действующие заказы";
        }
    }
}

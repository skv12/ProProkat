using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Stream mystream;
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            pp_dbEntities db = new pp_dbEntities();
            var query_closed = db.orders.Where<orders>(f => f.closed_date >= dateTimePickerFrom.Value).Where<orders>(t => t.closed_date <= dateTimePickerTo.Value).Where<orders>(s => s.status == "0");
            var query_active = db.orders.Where<orders>(t => t.date <= dateTimePickerTo.Value).Where<orders>(s => s.status == "1");
            var query_expired = db.orders.Where<orders>(s => s.status == "2");
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet closed_sheet = null;
            app.Visible = false;

            //Лист закрытых заказов
            closed_sheet = workbook.ActiveSheet;
            closed_sheet.Name = "Закрытые заказы";
            closed_sheet.Cells[1, 1] = "Выполненные заказы";
            closed_sheet.Range[closed_sheet.Cells[1, 1], closed_sheet.Cells[1, 2]].Merge();
            closed_sheet.Cells[2, 1] = "ID заказа";
            closed_sheet.Cells[2, 2] = "Клиент";
            closed_sheet.Cells[2, 3] = "Дата открытия";
            closed_sheet.Cells[2, 4] = "Дата закрытия";
            Excel.Range cellRange = (Excel.Range)closed_sheet.Cells[1, 1];
            Excel.Range rowRange = cellRange.EntireRow;
            Excel.Range colRange = cellRange.EntireColumn;

            int cellRow = 3;
            double cash = 0;
            foreach (var orders in query_closed)
            {
                closed_sheet.Cells[cellRow, 1] = orders.id.ToString();
                closed_sheet.Cells[cellRow, 2] = orders.client.ToString();
                closed_sheet.Cells[cellRow, 3] = orders.date.ToString();
                closed_sheet.Cells[cellRow, 4] = orders.closed_date.ToString();
                DateTime a = orders.closed_date.Value;
                DateTime b = orders.date.Value;
                double ddiff = (a - b).TotalHours / 24;
                cash += Convert.ToDouble(Convert.ToDouble(orders.deposit) / 20 * ddiff);
                cellRow++;
            }

            closed_sheet.Cells[cellRow + 1, 1] = "Итого выполнено";
            closed_sheet.Cells[cellRow + 1, 2] = "Заработано";
            closed_sheet.Cells[cellRow + 2, 1] = cellRow - 3;
            closed_sheet.Cells[cellRow + 2, 2] = cash;
            Excel.Range fit_cells = closed_sheet.UsedRange;
            fit_cells.EntireColumn.AutoFit();
            fit_cells.EntireRow.AutoFit();
            fit_cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fit_cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


            //Лист действующих заказов
            Excel.Worksheet active_sheet = null;
            active_sheet = (Excel.Worksheet)workbook.Worksheets.Add();
            active_sheet = workbook.ActiveSheet;
            active_sheet.Name = "Действующие заказы";
            active_sheet.Cells[1, 1] = "Действующие заказы";
            active_sheet.Range[active_sheet.Cells[1, 1], active_sheet.Cells[1, 4]].Merge();
            active_sheet.Cells[2, 1] = "ID заказа";
            active_sheet.Cells[2, 2] = "Клиент";
            active_sheet.Cells[2, 3] = "Дата открытия";
            active_sheet.Cells[2, 4] = "Cрок заказа";
            cellRange = (Excel.Range)active_sheet.Cells[1, 1];
            rowRange = cellRange.EntireRow;
            colRange = cellRange.EntireColumn;

            cellRow = 3;
            foreach (var orders in query_active)
            {
                active_sheet.Cells[cellRow, 1] = orders.id.ToString();
                active_sheet.Cells[cellRow, 2] = orders.client.ToString();
                active_sheet.Cells[cellRow, 3] = orders.date.ToString();
                active_sheet.Cells[cellRow, 4] = orders.rent.ToString();
                cellRow++;
            }

            active_sheet.Cells[cellRow + 1, 1] = "Итого действует";
            active_sheet.Cells[cellRow + 2, 1] = cellRow - 3;
            fit_cells = active_sheet.UsedRange;
            fit_cells.EntireColumn.AutoFit();
            fit_cells.EntireRow.AutoFit();
            fit_cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fit_cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            //Лист просроченных заказов
            Excel.Worksheet expired_sheet = null;
            expired_sheet = (Excel.Worksheet)workbook.Worksheets.Add();
            expired_sheet = workbook.ActiveSheet;
            expired_sheet.Name = "Просроченные заказы";
            expired_sheet.Cells[1, 1] = "Просроченные заказы";
            expired_sheet.Range[expired_sheet.Cells[1, 1], expired_sheet.Cells[1, 4]].Merge();
            expired_sheet.Cells[2, 1] = "ID заказа";
            expired_sheet.Cells[2, 2] = "Клиент";
            expired_sheet.Cells[2, 3] = "Дата открытия";
            expired_sheet.Cells[2, 4] = "Cрок заказа";
            cellRange = (Excel.Range)expired_sheet.Cells[1, 1];
            rowRange = cellRange.EntireRow;
            colRange = cellRange.EntireColumn;

            cellRow = 3;
            foreach (var orders in query_expired)
            {
                expired_sheet.Cells[cellRow, 1] = orders.id.ToString();
                expired_sheet.Cells[cellRow, 2] = orders.client.ToString();
                expired_sheet.Cells[cellRow, 3] = orders.date.ToString();
                expired_sheet.Cells[cellRow, 4] = orders.rent.ToString();
                cellRow++;
            }

            expired_sheet.Cells[cellRow + 1, 1] = "Итого просрочено";
            expired_sheet.Cells[cellRow + 2, 1] = cellRow - 3;
            fit_cells = expired_sheet.UsedRange;
            fit_cells.EntireColumn.AutoFit();
            fit_cells.EntireRow.AutoFit();
            fit_cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fit_cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            /*SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                    workbook.SaveAs(s, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }*/
            workbook.SaveAs("C:\\Users\\sanda\\Desktop\\dbExport.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
            this.Close();
        }
    }
}

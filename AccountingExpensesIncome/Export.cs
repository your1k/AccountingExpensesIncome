using System;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
namespace AccountingExpensesIncome
{
    class Export
    {
        [DllImport("User32.dll")]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int ProcessId);
        private static void KillExcel(Excel.Application theApp)
        {
            int id = 0;
            IntPtr intptr = new IntPtr(theApp.Hwnd);
            System.Diagnostics.Process p = null;
            try
            {
                GetWindowThreadProcessId(intptr, out id);
                p = System.Diagnostics.Process.GetProcessById(id);
                if (p != null)
                {
                    p.Kill();
                    p.Dispose();
                }
            }
            catch { }
        }

        public static void ExportData(Users User)
        {
            // объект Excel
            Excel.Application ObjWorkExcel = new Excel.Application();
            // добавляем рабочую книгу
            ObjWorkExcel.Workbooks.Add();
            // получаем активный лист
            Excel.Worksheet workSheet = (Excel.Worksheet)ObjWorkExcel.ActiveSheet;

            using (DataContext context = new DataContext()) 
            {
                int excelRow = 2;
                workSheet.Cells[1, "A"] = "Id";
                workSheet.Cells[1, "B"] = "Категория";
                workSheet.Cells[1, "C"] = "Операция";
                workSheet.Cells[1, "D"] = "Имя пользователя";
                workSheet.Cells[1, "E"] = "Описание";
                workSheet.Cells[1, "F"] = "Баланс";

                foreach (var item in context.Data.Where(x => x.UserId == User.Id).Select(x => new { x.Id, x.Category.Category, x.Operation.Operation, x.TransactionAmount, x.User.FullName, x.Description, x.Balance }).ToList()) 
                {
                    workSheet.Cells[excelRow, "A"] = item.Id;
                    workSheet.Cells[excelRow, "B"] = item.Category;
                    workSheet.Cells[excelRow, "C"] = item.Operation;
                    workSheet.Cells[excelRow, "D"] = item.FullName;
                    workSheet.Cells[excelRow, "E"] = item.Description;
                    workSheet.Cells[excelRow, "F"] = item.Balance;
                    excelRow++;
                }
            }
            // сохранение документа
            workSheet.SaveAs(Environment.CurrentDirectory + "\\" + "export.xls");
            // закрытие объекта Excel
            ObjWorkExcel.Quit();
            // закрытие процесса Excel
            KillExcel(ObjWorkExcel);
        }
    }
}

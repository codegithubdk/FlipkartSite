using Flipkart.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Flipkart
{
    class WriteResult
    {

        public static readonly string _rootPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Result");

        public static Excel.Application x1;
        public static Excel.Workbook _workbook;
        public static Excel.Worksheet _worksheet;

        public static void writeResultToExcel(string senarioname, string _res, string _msg, int _row, string File_Name)
        {

            string validate_res = _res;
            string original_res = "FAIL";

            if (validate_res == original_res)
            {
                int j=5;//_row=4;//col=3;

                ITakesScreenshot screenshotDriver_F = Hooks.driver as ITakesScreenshot;
                Screenshot screenshot_F = screenshotDriver_F.GetScreenshot();
                screenshot_F.SaveAsFile(_rootPath + @"Fail_SS.jpeg", ScreenshotImageFormat.Jpeg);

                Microsoft.Office.Interop.Excel.Application X1 = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = X1.Workbooks.Open(_rootPath + "Excel_REPORT.xlsx");

                Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1];

                for (int i = _row; i <= _row; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range = worksheet.UsedRange;
                    Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)range.Cells[i, j];
                    float Left = (float)((double)oRange.Left);
                    float Top = (float)((double)oRange.Top);
                    const float Width = 400;
                    const float height = 132;
                    worksheet.Shapes.AddPicture(_rootPath + @"Fail_SS.jpeg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, Width, height);
                    //workbook.Save();
                    //workbook.Close();
                }
                //Microsoft.Office.Interop.Excel.Range range = worksheet.UsedRange;
                //Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)range.Cells[4, 5];
                //float Left = (float)((double)oRange.Left);
                //float Top = (float)((double)oRange.Top);
                //const float Width = 400;
                //const float height = 132;
                //worksheet.Shapes.AddPicture(_rootPath + @"Fail_SS.jpeg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, Width, height);
                workbook.Save();
                workbook.Close();
                Console.WriteLine("screenshot applied on excel ");

            }


            //(save scenario result to excel) code
            x1 = new Excel.Application();
            // ExplicitWaiting.waitForTime(2000);
            bool _resDirExists = Directory.Exists(_rootPath);
            if (_resDirExists)
            {
                bool _fileExists = System.IO.File.Exists(_rootPath + File_Name + ".xlsx");
                if (_fileExists)
                {
                     _workbook = x1.Workbooks.Open(_rootPath + File_Name + ".xlsx");
                    _worksheet = _workbook.Sheets[1];
                    Excel.Range _range = _worksheet.UsedRange;

                    //Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)_range.Cells[_row, 5];
                    //float Left = (float)((double)oRange.Left);
                    //float Top = (float)((double)oRange.Top);
                    //const float Width = 500;
                    //const float height = 132;
                    //_worksheet.Shapes.AddPicture(path + @"Fail_SS.jpeg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, Width, height);
                    //_range.Cells[3, 2] = "senarioname";
                    //_range.Cells[3, 3] = "Result";
                    //_range.Cells[3, 4] = "message";
                    _range.Cells[_row, 2] = senarioname;
                    _range.Cells[_row, 3] = _res;
                    _range.Cells[_row, 4] = _msg;
                    _workbook.Save();
                    _workbook.Close();


                }
                else
                {
                    Console.WriteLine("Output file does not exists........");
                }

            }
            else
            {
                DirectoryInfo _newDir = Directory.CreateDirectory(_rootPath);
                //ToDo code for copy file from backup directory.
            }
        }

        //public static void closeExcel()
        //{
        //    _workbook.Close();
        //}
    }
}

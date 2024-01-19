using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data;
using System.Reflection;

using OfficeOpenXml;

using MCT.CCAlib.Utilities;

using CCALib_Testing.Interfaces;
using CCALib_Testing.Models;
using System.Drawing;
using OfficeOpenXml.Attributes;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;

namespace CCALib_Testing.Test_Utilities
{
    internal class Test_ExcelFileCreation : ITest_Base
    {
        //private AppConfig _appConfig;
        //private Logger _logger;

        //public void Initialize(AppConfig appConfig, Logger logger)
        //{
        //    _appConfig = appConfig;
        //    _logger = logger;
        //}

        //public void Run()
        //{
        //    ExcelSpreadsheet spreadsheet = BuildSampleDataObject();
        //    CreateExcelFile(spreadsheet);
        //}

        //private ExcelSpreadsheet BuildSampleDataObject()
        //{
        //    ExcelSpreadsheet spreadsheet = new ExcelSpreadsheet();

        //    spreadsheet.WorkbookName = "TestExcelFile";

        //    for (int i = 0; i < 10; ++i)
        //    {
        //        spreadsheet.Worksheets.Add(GetSheet(i + 1));
        //    }

        //    return spreadsheet;
        //}

        //private DataTable GetSheet(int sheetNumber)
        //{
        //    DataColumn column;
        //    DataTable table = new DataTable($"Sheet number {sheetNumber}");

        //    Type type = typeof(UasErrorReportEntry);

        //    foreach (var property in type.GetProperties())
        //    {
        //        column = new DataColumn();
        //        column.DataType = property.PropertyType;
        //        column.ColumnName= property.Name;
        //        table.Columns.Add(column);
        //    }

        //    DataRow dataRow = null;

        //    // Add rows to table
        //    for (int i = 0; i < 5; ++i)
        //    {
        //        dataRow = table.NewRow();
        //        dataRow[table.Columns[0].ColumnName] = DateTime.Now;
        //        dataRow[table.Columns[1].ColumnName] = $"Entry {sheetNumber}{i}{i + 2}";
        //        dataRow[table.Columns[2].ColumnName] = $"Entry {sheetNumber}{i}{i + 3}";
        //        dataRow[table.Columns[3].ColumnName] = $"Entry {sheetNumber}{i}{i + 4}";
        //        dataRow[table.Columns[4].ColumnName] = $"Entry {sheetNumber}{i}{i + 5}";
        //        dataRow[table.Columns[5].ColumnName] = $"Entry {sheetNumber}{i}{i + 5}";
        //        dataRow[table.Columns[6].ColumnName] = DateTime.Now.AddDays(1);
        //        dataRow[table.Columns[7].ColumnName] = DateTime.Now.AddDays(2);
        //        dataRow[table.Columns[8].ColumnName] = $"Entry {sheetNumber}{i}{i + 5}";
        //        dataRow[table.Columns[9].ColumnName] = $"Entry {sheetNumber}{i}{i + 5}";
        //        dataRow[table.Columns[10].ColumnName] = $"Entry {sheetNumber}{i}{i + 5}";

        //        table.Rows.Add(dataRow);
        //    }

        //    return table;
        //}

        //private void CreateExcelFile(ExcelSpreadsheet spreadsheet)
        //{
        //    ExcelPackage excelFile = FileTool.CreateExcelFile(spreadsheet);

        //    _appConfig.Email.Subject = "Assessment Manager Error Report - TEST";

        //    FileTool.SendExcelFileInEmail(_appConfig.Email, excelFile);
        //}
    }
}

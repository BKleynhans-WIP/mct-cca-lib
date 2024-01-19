using System;
using System.Data;

using OfficeOpenXml.Style;
using OfficeOpenXml;

namespace MCT.CCAlib.Utilities
{
    public class ExcelParser
    {
        /// <summary>
        /// Add some custom formatting to the Excel File object being created
        /// </summary>
        /// <param name="worksheet"></param>
        /// <returns></returns>
        public static ExcelWorksheet FormatWorksheet(ExcelWorksheet worksheet)
        {
            int row = 1;

            worksheet.DefaultRowHeight = 12;

            worksheet.Row(row).Height = 20;
            worksheet.Row(row).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            worksheet.Row(row).Style.Font.Bold = true;

            return worksheet;
        }

        /// <summary>
        /// Takes the first row form the DataTable and adds that row into the 
        /// ExcelWorksheet as column headers
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static ExcelWorksheet AddWorksheetHeaders(ExcelWorksheet worksheet, DataTable dataTable)
        {
            int sheetColumn = 0;

            foreach (DataColumn datasetColumn in dataTable.Columns)
            {
                sheetColumn++;
                worksheet.Cells[1, sheetColumn].Value = datasetColumn.ColumnName;
            }

            return worksheet;
        }

        /// <summary>
        /// Add all the rows in the provided DataTable to the provided ExcelWorksheet object
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static ExcelWorksheet AddWorksheetRows(ExcelWorksheet worksheet, DataTable dataTable)
        {
            int currentRow = 1;
            int currentColumn = 1;

            foreach (var row in dataTable.Rows)
            {
                foreach (var column in worksheet.Columns)
                {
                    worksheet.Cells[currentRow + 1, currentColumn].Value = dataTable.Rows[currentRow - 1].ItemArray[currentColumn - 1]?.ToString() ?? String.Empty;
                    currentColumn++;
                }

                currentColumn = 1;
                currentRow++;
            }

            return worksheet;
        }

        /// <summary>
        /// After the data has been added to the worksheet, auto-size the columns
        /// to the data in the table
        /// </summary>
        /// <param name="worksheet"></param>
        /// <returns></returns>
        public static ExcelWorksheet AutoFitColumns(ExcelWorksheet worksheet)
        {
            foreach (var column in worksheet.Columns)
            {
                column.AutoFit();
            }

            return worksheet;
        }
    }
}

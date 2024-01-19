using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using OfficeOpenXml;

using MCT.CCAlib.Interfaces;
using MCT.CCAlib.Models.Config;
using MCT.CCAlib.Models.FileTool;

namespace MCT.CCAlib.Utilities
{
    public class FileTool : IFileTool
    {
        private readonly ILogger<FileTool> _logger;
        private readonly IEmail _email;

        public FileTool(ILogger<FileTool> logger, IEmail email)
        {
            _logger = logger;
            _email = email;
        }


        /// <summary>
        /// Reads a JSON file and returns a JToken object
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public JToken ReadJsonFile(string filePath)
        {
            try
            {
                JToken jToken = JsonConvert.DeserializeObject<JToken>(File.ReadAllText(filePath));
                return jToken;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Reads an Excel file and returns a ExcelWorkbook object that contains a list of DataTables, one for each sheet
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public ExcelSpreadsheet ReadExcelFile(string filePath)
        {
            try
            {
                ExcelSpreadsheet excelWorkbook = new ExcelSpreadsheet();
                // If you use EPPlus in a noncommercial context according to the Polyform Noncommercial license:
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                excelWorkbook.WorkbookName = GetFilenameWithExtension(filePath);

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                    {
                        DataTable dt = new DataTable(worksheet.Name);
                        ExcelCellAddress startCell = worksheet.Dimension.Start;
                        ExcelCellAddress endCell = worksheet.Dimension.End;

                        //Add columns to datatable with header row column name
                        for (int colIndex = startCell.Column; colIndex <= endCell.Column; colIndex++)
                        {
                            dt.Columns.Add(worksheet.Cells[startCell.Row, colIndex].Text);
                        }
                        //Loop rows to add each cell to datatable
                        for (int rowIndex = startCell.Row + 1; rowIndex <= endCell.Row; rowIndex++)
                        {
                            DataRow row = dt.NewRow();
                            int cellIndex = 0;
                            for (int colIndex = startCell.Column; colIndex <= endCell.Column; colIndex++)
                            {
                                row[cellIndex++] = worksheet.Cells[rowIndex, colIndex].Text;
                            }
                            dt.Rows.Add(row);
                        }

                        excelWorkbook.Worksheets.Add(dt);
                    }
                }

                return excelWorkbook;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Takes an ExcelSpreadsheet object and converts it into an ExcelPackage object
		/// that can be saved or emailed as an Excel file.
        /// </summary>        
        /// <param name="excelSpreadsheet">An instancne of the ExcelSpreadsheet object. The
		/// WorkbookName property will be used as the output filename</param>
        public ExcelPackage CreateExcelFile(ExcelSpreadsheet excelSpreadsheet)
        {
            // If you use EPPlus in a noncommercial context according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new ExcelPackage(excelSpreadsheet.WorkbookName);

            foreach (var dataTable in excelSpreadsheet.Worksheets)
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(dataTable.TableName);

                worksheet = ExcelParser.FormatWorksheet(worksheet);
                worksheet = ExcelParser.AddWorksheetHeaders(worksheet, dataTable);
                worksheet = ExcelParser.AddWorksheetRows(worksheet, dataTable);
                worksheet = ExcelParser.AutoFitColumns(worksheet);
            }

            return excelPackage;
        }

        /// <summary>
        /// Takes the provided ExcelPackage object, converts it to bytecode and sends it
        /// as an Excel attachment using the Email preferences defined in appConfig.Email
        /// </summary>
        /// <param name="appConfig"></param>
        /// <param name="excelPackage"></param>
        /// <returns>True/False depending on whether send succeeded or not</returns>
        public bool SendExcelFileInEmail(EmailConfig emailConfig, ExcelPackage excelPackage)
        {
            byte[] excelFileAsBytes = excelPackage.GetAsByteArray();

            return _email.SendEmail(
                        emailConfig.To,
                        emailConfig.Cc,
                        emailConfig.Bcc,
                        emailConfig.Subject,
                        emailConfig.Body,
                        excelFileAsBytes,
                        $"{excelPackage.File.Name}.xlsx"
                    );
        }

        /// <summary>
        /// Takes an ExcelPackage object and saves it as an Excel file to the provided path
        /// </summary>
        /// <param name="fileNameAndPath"></param>
        /// <param name="excelPackage"></param>
        private void SaveFile(string fileNameAndPath, ExcelPackage excelPackage)
        {
            if (File.Exists(fileNameAndPath))
                File.Delete(fileNameAndPath);

            // Create excel file on physical disk 
            FileStream objFileStream = File.Create(fileNameAndPath);
            objFileStream.Close();

            // Write content to excel file 
            File.WriteAllBytes(fileNameAndPath, excelPackage.GetAsByteArray());

            //Close Excel package
            excelPackage.Dispose();
        }

        /// <summary>
        /// Reads an XML file and returns an XML object.
        /// 
        /// To access an XML element, use the command : [XML obj returned].Descendants(XName.Get("[The name of the element you want]"))
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public XDocument ReadXmlFile(string filePath)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(filePath);
                return xmlDoc;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get a list of files from the specified path
        /// </summary>
        /// <param name="fullyQualifiedPath"></param>
        /// <returns></returns>
        public List<string> GetFilesInDirectory(string fullyQualifiedPath)
        {
            try
            {
                List<string> files = new List<string>();

                if (Directory.Exists(fullyQualifiedPath))
                { }
                files = Directory.GetFiles(fullyQualifiedPath).ToList<string>();

                return files;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Breaks the full file path into segements by splitting on the backslash character 
        /// and returns the filename WITH the extension
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string GetFilenameWithExtension(string file)
        {
            try
            {
                string[] pathSegments = file.Split('\\');
                return pathSegments[pathSegments.Length - 1];
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Breaks the full file path into segements by splitting on the backslash character 
        /// and returns the filename WITHOUT the extension
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string GetFilenameWithoutExtension(string file)
        {
            try
            {
                string[] pathSegments = file.Split('\\');
                string filenameExtension = pathSegments[pathSegments.Length - 1];
                return filenameExtension.Substring(0, filenameExtension.LastIndexOf("."));
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Calls method to get the filename
        /// Breaks filename into segments by splitting on the supplied "splitOnChar" and returns 
        /// the first element (all files should start with the vendor name)
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string GetFirstStringElementFromFilename(string file, char splitOnChar)
        {
            try
            {
                string[] fileNameSegments = GetFilenameWithExtension(file).Split(splitOnChar);
                return fileNameSegments[0];
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Xml.Linq;

using MCT.CCAlib.Models.Config;
using MCT.CCAlib.Models.FileTool;

namespace MCT.CCAlib.Interfaces
{
    public interface IFileTool
    {
        ExcelPackage CreateExcelFile(ExcelSpreadsheet excelSpreadsheet);
        string GetFilenameWithExtension(string file);
        string GetFilenameWithoutExtension(string file);
        List<string> GetFilesInDirectory(string fullyQualifiedPath);
        string GetFirstStringElementFromFilename(string file, char splitOnChar);
        ExcelSpreadsheet ReadExcelFile(string filePath);
        JToken ReadJsonFile(string filePath);
        XDocument ReadXmlFile(string filePath);
        bool SendExcelFileInEmail(EmailConfig emailConfig, ExcelPackage excelPackage);
    }
}
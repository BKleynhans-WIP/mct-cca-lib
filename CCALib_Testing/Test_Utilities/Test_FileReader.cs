using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.Reflection;

using MCT.CCAlib.Utilities;

using CCALib_Testing.Interfaces;
using MCT.CCAlib;

namespace CCALib_Testing.Test_Utilities
{
    public class Test_FileReader : ITest_Base
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
        //    Test_JsonFileReader();
        //    Test_ExcelFileReader();
        //    Test_XmlFileReader();
        //}

        //public void Test_JsonFileReader()
        //{
        //    // Test the JSON file reader
        //    string jsonPath = Path.Join(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "TestFiles", "StoredProcedureDefinitions.json");
        //    var jsonObj = FileTool.ReadJsonFile(jsonPath);

        //    _logger.LogInformation($"Testing the JsonFileReader >> {EvaluateResult(jsonObj)}");

        //    Console.WriteLine();
        //}

        //public void Test_ExcelFileReader()
        //{
        //    // Test the Excel file reader
        //    string excelPath = Path.Join(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "TestFiles", "UASNY UPHN Data Exchange Data Dictionary v1.13.4 2023-01-05.xlsx");
        //    var excelObj = FileTool.ReadExcelFile(excelPath);

        //    _logger.LogInformation($"Testing the ExcelFileReader >> {EvaluateResult(excelObj)}");

        //    Console.WriteLine();
        //}

        //public void Test_XmlFileReader()
        //{
        //    // Test the XML file reader
        //    string xmlPath = Path.Join(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "TestFiles", "UAS_1.13_LTC_Plan_Data_Exchange_Schema_Sample_2023-01-04.xml");
        //    var xmlObj = FileTool.ReadXmlFile(xmlPath);

        //    _logger.LogInformation($"Testing the XmlFileReader >> {EvaluateResult(xmlObj)}");

        //    Console.WriteLine();
        //}

        //private string EvaluateResult(dynamic obj)
        //{
        //    return obj == null ? "Object is empty" : "Object contains data";
        //}
    }
}

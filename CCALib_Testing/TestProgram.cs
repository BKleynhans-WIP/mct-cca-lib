using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Reflection;

using MCT.CCAlib.Utilities;
using MCT.CCAlib.Interfaces;

using CCALib_Testing.Test_Utilities;
using CCALib_Testing.Interfaces;
using MCT.CCAlib;

namespace CCALib_Testing
{
    /// <summary>
    /// The TestProgram contains the Dependency Injection definitions for the tests
    /// required for the CCALib library
    /// </summary>
    public class TestProgram
    {
        //private Logger _logger;
        //private AppConfig _appConfig;
        //private List<ITest_Base> testObjects;

        ///// <summary>
        ///// Add the test classes that need to be tested during the test run
        ///// </summary>
        //public TestProgram(AppConfig appConfig, Logger logger)
        //{
        //    _appConfig = appConfig;
        //    _logger = logger;

        //    testObjects = new List<ITest_Base>();

        //    //testObjects.Add(new Test_FileReader());
        //    //testObjects.Add(new Test_MsSqlCrud());
        //    testObjects.Add(new Test_OracleCrud());
        //    //testObjects.Add(new Test_ExcelFileCreation());
        //}

        ///// <summary>
        ///// Run the test files, one by one
        ///// </summary>
        //public void Run()
        //{
        //    foreach (ITest_Base testObject in testObjects)
        //    {
        //        _logger.LogInformation("Initializing Class");                

        //        testObject.Initialize(_appConfig, _logger);
        //        testObject.Run();

        //        _logger.LogInformation("Execution completed");
        //    }
        //}
    }
}

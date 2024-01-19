using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;

using Microsoft.IdentityModel.Tokens;

using MCT.CCAlib.Utilities;

using CCALib_Testing.Test_Utilities;
using CCALib_Testing.Enums;
using CCALib_Testing.Config;
using CCALib_Testing;
using MCT.CCAlib;

namespace CCALib_Testing
{
    /// <summary>
    /// Main testing program to check functionality of the CCALib library
    /// </summary>
    class Program
    {
        //private static int _expectedNrOfArguments = 0;

        //public static AppConfig _appConfig;
        //public static Logger _logger;

        static void Main(string[] args)
        {
            //    _logger = new Logger(Assembly.GetEntryAssembly().GetName().Name);

            //    EvaluateArguments(args);

            //    _appConfig = Config.Config.Init(_logger);

            //    RunTestProgram();

            //    Environment.Exit((int)ExitCode.Success); // Exit Code 0
        }

        ///// <summary>
        ///// Evaluate the arguments passed in from the command line to determine if they conform to requirements
        ///// </summary>
        ///// <param name="args"></param>
        //private static void EvaluateArguments(string[] args)
        //{
        //    int nrOfArgs = args.Length;

        //    if (nrOfArgs != _expectedNrOfArguments)
        //    {
        //        _logger.LogError("An invalid number of arguments were passed to the program.  Please check " +
        //                $"your commandline arguments and try again");

        //        Environment.Exit((int)ExitCode.InvalidNumberOfArguments); // Exit code 11
        //    }
        //}

        ///// <summary>
        ///// Create an instance of and run the TestProgram class.  This class contains all the individualized tests
        ///// that are present currently.
        ///// </summary>
        //private static void RunTestProgram()
        //{
        //    TestProgram testProgram = new TestProgram(_appConfig, _logger);
        //    testProgram.Run();
        //}
    }
}

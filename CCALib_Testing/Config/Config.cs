using System;
using System.Collections.Generic;
using System.Text;

using MCT.CCAlib.Utilities;

namespace CCALib_Testing.Config
{
    public static class Config
    {
        private static string ASPNET_ENV_VARIABLE = "ASPNETCORE_ENVIRONMENT";

  //      public static AppConfig Init(Logger logger)
  //      {
  //          LibConfig libConfig = new LibConfig(logger);
  //          return GetEnvironment(libConfig);
  //      }

  //      /// <summary>
		///// Gets the value of a system environment variable
		///// Exits application if the system environment variable doesn't exist
		///// </summary>
		///// <returns></returns>
		//internal static AppConfig GetEnvironment(LibConfig libConfig)
  //      {
  //          var environment = Environment.GetEnvironmentVariable(ASPNET_ENV_VARIABLE);
  //          Console.WriteLine("Environment is: " + environment);

  //          if (environment == null)
  //          {
  //              Console.WriteLine("Configuration::GetAppSettingsFromFile. Environment not found!");
  //          }
  //          else
  //          {
  //              return libConfig.GetConfig<AppConfig>(environment);
  //          }

  //          return null;
  //      }
    }
}

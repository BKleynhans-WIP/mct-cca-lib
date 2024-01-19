
using MCT.CCAlib.Utilities;
using System;
using Xunit;
using System.Linq;

namespace MCT.CCAlib.Tests
{
	public class ConfigurationTests
	{
		//private LibConfig _libConfig;

		//public ConfigurationTests()
		//{
		//	_libConfig = new LibConfig(new Logger("MCT.CCAlib.Tests"));
		//}

		//#region EmailConfig

		//[Fact]
		//public void TestAppConfig_EmailConfig_AllEnvironments()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("debug");

		//	Assert.Equal("smtp1.excellus.com", appConfig.Email.SmtpServer);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_Debug_TO()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("debug");

		//	Assert.Contains("FirstName.LastName@excellus.com", appConfig.Email.To);
		//	Assert.Contains("DistributionList@excellus.com", appConfig.Email.To);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_Debug_CC()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("debug");

		//	Assert.Null(appConfig.Email.Cc);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_DEV_TO()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("DEV");

		//	Assert.Contains("IT.Medical.Management.Portfolio@excellus.com", appConfig.Email.To);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_DEV_CC()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("DEV");

		//	Assert.Null(appConfig.Email.Cc);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_TST_To()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TST");

		//	Assert.Contains("IT.Medical.Management.Portfolio@excellus.com", appConfig.Email.To);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_TST_CC()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TST");

		//	Assert.Null(appConfig.Email.Cc);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_UAT_TO()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("UAT");

		//	Assert.Contains("ClinicalOperationsManagedCareDomain@excellus.com", appConfig.Email.To);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_UAT_CC()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("UAT");

		//	Assert.Contains("IT.Medical.Management.Portfolio@excellus.com", appConfig.Email.Cc);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_TRN_TO()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TRN");

		//	Assert.Contains("ClinicalOperationsManagedCareDomain@excellus.com", appConfig.Email.To);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_TRN_CC()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TRN");

		//	Assert.Contains("IT.Medical.Management.Portfolio@excellus.com", appConfig.Email.Cc);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_PRD_TO()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("PRD");

		//	Assert.Contains("business.distribution.list@excellus.com", appConfig.Email.To);
		//}

		//[Fact]
		//public void TestAppConfig_EmailConfig_PRD_CC()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("PRD");

		//	Assert.Contains("IT.Medical.Management.Portfolio@excellus.com", appConfig.Email.Cc);
		//}

		//#endregion

		//#region FileConfig

		//[Fact]
		//public void TestAppConfig_FileConfig_Debug()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("debug");

		//	Assert.Equal(@"C:\Folder\Output\", appConfig.File.OutputFileLocation);
		//}

		//[Fact]
		//public void TestAppConfig_FileConfig_DEV()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("DEV");

		//	Assert.Equal(@"\Output\", appConfig.File.OutputFileLocation);
		//}

		//[Fact]
		//public void TestAppConfig_FileConfig_TST()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TST");

		//	Assert.Equal(@"\Output\", appConfig.File.OutputFileLocation);
		//}

		//[Fact]
		//public void TestAppConfig_FileConfig_UAT()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("UAT");

		//	Assert.Equal(@"\Output\", appConfig.File.OutputFileLocation);
		//}

		//[Fact]
		//public void TestAppConfig_FileConfig_TRN()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TRN");

		//	Assert.Equal(@"\Output\", appConfig.File.OutputFileLocation);
		//}

		//[Fact]
		//public void TestAppConfig_FileConfig_PRD()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("PRD");

		//	Assert.Equal(@"\Output\", appConfig.File.OutputFileLocation);
		//}

		//#endregion

		//#region RESTConfig

		//[Fact]
		//public void TestAppConfig_RESTConfig_All()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("debug");

		//	Assert.Equal("0-WEBSERVICE", appConfig.REST.Submitter);
		//}


		//[Fact]
		//public void TestAppConfig_RESTConfig_Debug()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("debug");

		//	Assert.Equal("https://caedevwwv02.excellus.com:447/userapi/v1/", appConfig.REST.ApiBaseAddress);
		//}

		//[Fact]
		//public void TestAppConfig_RESTConfig_DEV()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("DEV");

		//	Assert.Equal("https://caedevwwv02.excellus.com:447/userapi/v1/", appConfig.REST.ApiBaseAddress);
		//}

		//[Fact]
		//public void TestAppConfig_RESTConfig_TST()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TST");

		//	Assert.Equal("https://CASVCTST.excellus.com/userapi/v1/", appConfig.REST.ApiBaseAddress);
		//}

		//[Fact]
		//public void TestAppConfig_RESTConfig_UAT()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("UAT");

		//	Assert.Equal("https://CAEUATWWV01.excellus.com:447/userapi/v1/", appConfig.REST.ApiBaseAddress);
		//}

		//[Fact]
		//public void TestAppConfig_RESTConfig_TRN()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TRN");

		//	Assert.Equal("https://CAETRNWWV01.excellus.com:447/userapi/v1/", appConfig.REST.ApiBaseAddress);
		//}

		//[Fact]
		//public void TestAppConfig_RESTConfig_PRD()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("PRD");

		//	Assert.Equal("https://CASVCPRD.excellus.com/userapi/v1/", appConfig.REST.ApiBaseAddress);
		//}

		//#endregion

		//#region SOAFConfig

		//[Fact]
		//public void TestAppConfig_SOAFConfig_Debug()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("debug");

		//	Assert.Equal("https://caedevwwv02.excellus.com:447/SOAFServices/", appConfig.SOAF.ApiURL);
		//}

		//[Fact]
		//public void TestAppConfig_SOAFConfig_DEV()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("DEV");

		//	Assert.Equal("https://caedevwwv02.excellus.com:447/SOAFServices/", appConfig.SOAF.ApiURL);
		//}

		//[Fact]
		//public void TestAppConfig_SOAFConfig_TST()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TST");

		//	Assert.Equal("https://CASVCTST.excellus.com/SOAFServices/", appConfig.SOAF.ApiURL);
		//}

		//[Fact]
		//public void TestAppConfig_SOAFConfig_UAT()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("UAT");

		//	Assert.Equal("https://CAEUATWWV01.excellus.com:447/SOAFServices/", appConfig.SOAF.ApiURL);
		//}

		//[Fact]
		//public void TestAppConfig_SOAFConfig_TRN()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TRN");

		//	Assert.Equal("https://CAETRNWWV01.excellus.com:447/SOAFServices/", appConfig.SOAF.ApiURL);
		//}

		//[Fact]
		//public void TestAppConfig_SOAFConfig_PRD()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("PRD");

		//	Assert.Equal("https://CASVCPRD.excellus.com/SOAFServices/", appConfig.SOAF.ApiURL);
		//}

		//#endregion

		//#region SQLConfig

		//[Fact]
		//public void TestAppConfig_SQLConfig_Debug()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("debug");

		//	Assert.Equal("customdb_DEV", appConfig.SQL.CustomDB);
		//}

		//[Fact]
		//public void TestAppConfig_SQLConfig_DEV()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("DEV");

		//	Assert.Equal("customdb_DEV", appConfig.SQL.CustomDB);
		//}

		//[Fact]
		//public void TestAppConfig_SQLConfig_TST()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TST");

		//	Assert.Equal("customdb_TST", appConfig.SQL.CustomDB);
		//}

		//[Fact]
		//public void TestAppConfig_SQLConfig_UAT()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("UAT");

		//	Assert.Equal("customdb_UAT", appConfig.SQL.CustomDB);
		//}

		//[Fact]
		//public void TestAppConfig_SQLConfig_TRN()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("TRN");

		//	Assert.Equal("customdb_TRN", appConfig.SQL.CustomDB);
		//}

		//[Fact]
		//public void TestAppConfig_SQLConfig_PRD()
		//{
		//	var appConfig = _libConfig.GetConfig<AppConfig>("PRD");

		//	Assert.Equal("customdb_PRD", appConfig.SQL.CustomDB);
		//}

		//#endregion
	}
}

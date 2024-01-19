using CCALib_Testing.Interfaces;
using MCT.CCAlib.Interfaces;
using System.Data;

namespace CCALib_Testing.Test_Utilities
{
	public class Test_OracleCrud : ITest_Base
	{
		//private AppConfig _appConfig;
		//private MCT.CCAlib.Utilities.Logger _logger;

		//OracleUtility _databaseUtility;


		//public void Initialize(AppConfig appConfig, MCT.CCAlib.Utilities.Logger logger)
		//{
		//	_appConfig = appConfig;
		//	_logger = logger;

		//	_databaseUtility = new OracleUtility(_appConfig.Oracle);
		//}

		//public void Run()
		//{
		//	Test_Select10RowsFromOracle();
		//}

		//public void Test_Select10RowsFromOracle()
		//{
		//	string medicaidNr = "EU51994J";
		//	string dateOfBirth = "03/04/2012";

		//	string queryString = $"SELECT MEME_CK FROM FACETCOR.CMC_MEME_MEMBER WHERE " +
		//					$"MEME_MEDCD_NO = '{medicaidNr}' AND MEME_BIRTH_DT = TO_DATE('{dateOfBirth}', 'mm/dd/yyyy') " +
		//					$"ORDER BY MEME_ORIG_EFF_DT DESC " +
		//					$"FETCH NEXT 1 ROW ONLY";

		//	var result = _databaseUtility.ExecuteReaderQuery(ISqlDatabaseUtility.QueryType.ReadOnly, queryString);
		//	DataTable dt = new DataTable();
		//	dt = result.Tables[0];

		//	if (dt.Rows.Count > 0)
		//	{
		//		_logger.LogInformation($"Successfully retrieved the External Member Id : {dt.Rows[0]["MEME_CK"].ToString()} from Oracle");
		//	}
		//	else
		//	{
		//		_logger.LogWarning("We were unable to retrieve any records from Oracle");
		//	}
		//}
	}
}

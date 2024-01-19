using MCT.CCAlib.Interfaces;
using MCT.CCAlib.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Xunit;

namespace MCT.CCAlib.Tests
{
    public class SQLUtilityTests
	{
		//private SQLConfig _sqlConfig;

		//public SQLUtilityTests()
		//{
		//	LibConfig libConfig = new LibConfig(new Logger("MCT.CCAlib.Tests"));
		//	var appConfig = libConfig.GetConfig<AppConfig>("debug");
		//	_sqlConfig = appConfig.SQL;
		//}

		//[Fact]
		//public void TestSQLUtility_DataReader_NoParmas_ReturnTable()
		//{
		//	SQLUtility sqlUtility = new SQLUtility(_sqlConfig);

		//	DataSet ds = sqlUtility.ExecuteReaderQuery(ISqlDatabaseUtility.QueryType.ReadOnly, "ehpp_custom_CA_BRS_SERVER_LIST");

		//	Assert.True(ds.Tables[0].Rows.Count > 0);
		//}

		//[Fact]
		//public void TestSQLUtility_DataReader_NoParams_ReturnTables()
		//{
		//	SQLUtility sqlUtility = new SQLUtility(_sqlConfig);

		//	DataSet ds = sqlUtility.ExecuteReaderQuery(ISqlDatabaseUtility.QueryType.ReadOnly, "usp_GetJWTAuthenticationSettings");

		//	Assert.Equal(2, ds.Tables.Count);
		//}

		//[Fact]
		//public void TestSQLUtility_DataReader_WithParams_ReturnTable()
		//{
		//	List<SQLParameter> parameters = new List<SQLParameter> {
		//		new SQLParameter("pProcessName", "PREAUTH_CHECK")
		//	};
		//	SQLUtility sqlUtility = new SQLUtility(_sqlConfig);

		//	DataSet ds = sqlUtility.ExecuteReaderQuery(ISqlDatabaseUtility.QueryType.ReadOnly, "ehpp_custom_preauthparams_lookup", parameters);

		//	Assert.True(ds.Tables[0].Rows.Count > 0);
		//	Assert.True(ds.Tables[1].Rows.Count > 0);
		//	Assert.True(ds.Tables[2].Rows.Count > 0);
		//}

		//[Fact]
		//public void TestSQLUtility_Scaler_WithParams_ReturnId()
		//{
		//	List<SQLParameter> parameters = new List<SQLParameter> {
		//		new SQLParameter("CareType", "Home Care")
		//	};
		//	SQLUtility sqlUtility = new SQLUtility(_sqlConfig);

		//	int id = Convert.ToInt32(sqlUtility.ExecuteScalarQuery(ISqlDatabaseUtility.QueryType.ReadOnly, "ehpp_custom_ABRE_GetCareTypeFromStringLocale", parameters));

		//	Assert.Equal(3, id);
		//}

		//[Fact(Skip = "verify query doesn't return results before running")]
		////[Fact]
		//public void TestSQLUtility_Scaler_NoParams_ReturnNullObject()
		//{
		//	SQLUtility sqlUtility = new SQLUtility(_sqlConfig);

		//	object obj = sqlUtility.ExecuteScalarQuery(ISqlDatabaseUtility.QueryType.ReadOnly, "usp_CAE1259_CustomUpdateCases_GetCases");

		//	Assert.Null(obj);
		//}

		//[Fact(Skip = "verify query doesn't return results before running")]
		////[Fact]
		//public void TestSQLUtility_Reader_NoParams_ReturnEmptyTable()
		//{
		//	SQLUtility sqlUtility = new SQLUtility(_sqlConfig);

		//	DataSet ds = sqlUtility.ExecuteReaderQuery(ISqlDatabaseUtility.QueryType.ReadOnly, "usp_CAE1259_CustomUpdateCases_GetCases");

		//	Assert.True(ds.Tables[0].Rows.Count == 0);
		//}

		//[Fact]
		//public void TestSQLUtility_BuildParameterList_ReturnEqual_ListOfStoredProcedureParameter()
		//{
  //          SQLUtility sqlUtility = new SQLUtility(_sqlConfig);

  //          Dictionary<string, string> inputDictionary = new Dictionary<string, string>()
  //          {
  //              ["question_text"] = "BEN QuestionText",
  //              ["source_identifier"] = "BEN SourceIdentifier",
		//		["answer_value"] = "999"
  //          };

		//	List<StoredProcedureParameter> expectedParameterObject = new List<StoredProcedureParameter>();
  //          expectedParameterObject.Add(new StoredProcedureParameter() { Parameter = "question_text", Value = "BEN QuestionText" });
  //          expectedParameterObject.Add(new StoredProcedureParameter() { Parameter = "source_identifier", Value = "BEN SourceIdentifier" });
  //          expectedParameterObject.Add(new StoredProcedureParameter() { Parameter = "answer_value", Value = "999" });

		//	var actualParameterObject = sqlUtility.BuildParameterList(inputDictionary);

  //          Assert.Equal(JsonConvert.SerializeObject(expectedParameterObject), JsonConvert.SerializeObject(actualParameterObject));
  //      }

  //      [Fact]
  //      public void TestSQLUtility_BuildParameterList_ReturnNotEqual_ListOfStoredProcedureParameter()
  //      {
  //          SQLUtility sqlUtility = new SQLUtility(_sqlConfig);

  //          Dictionary<string, string> inputDictionary = new Dictionary<string, string>()
  //          {
  //              ["question_text"] = "BEN QuestionText",
  //              ["source_identifier"] = "BEN SourceIdentifier"
  //          };

  //          List<StoredProcedureParameter> expectedParameterObject = new List<StoredProcedureParameter>();
  //          expectedParameterObject.Add(new StoredProcedureParameter() { Parameter = "question_text", Value = "BEN QuestionText" });
  //          expectedParameterObject.Add(new StoredProcedureParameter() { Parameter = "source_identifier", Value = "BEN SourceIdentifier" });
  //          expectedParameterObject.Add(new StoredProcedureParameter() { Parameter = "answer_value", Value = "999" });

  //          var actualParameterObject = sqlUtility.BuildParameterList(inputDictionary);

  //          Assert.NotEqual(JsonConvert.SerializeObject(expectedParameterObject), JsonConvert.SerializeObject(actualParameterObject));
  //      }
    }
}

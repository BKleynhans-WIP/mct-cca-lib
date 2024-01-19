using System;
using System.Collections.Generic;

using MCT.CCAlib.Interfaces;

using CCALib_Testing.Interfaces;

namespace CCALib_Testing.Test_Utilities
{
	public class Test_MsSqlCrud : ITest_Base
	{
		//private AppConfig _appConfig;
		//private MCT.CCAlib.Utilities.Logger _logger;

		//ISqlDatabaseUtility _databaseUtility;
		//IDatabaseManager _databaseManager;

		//public void Initialize(AppConfig appConfig, MCT.CCAlib.Utilities.Logger logger)
		//{
		//	_appConfig = appConfig;
		//	_logger = logger;

		//	_databaseUtility = new SQLUtility(_appConfig.SQL);
		//	_databaseManager = new SQLManager(_databaseUtility, Program._logger);
		//}

		//public void Run()
		//{
		//	Test_GetStoredProceduresFromSql();
		//	Test_InsertSingleWithStoredProcedure();
		//}

		//public void Test_GetStoredProceduresFromSql()
		//{
		//	_logger.LogInformation("Attempting to get stored procedures from SQL");

		//	var storedProcedures = _databaseManager.GetStoredProceduresFromSql();

		//	if (storedProcedures.Count > 0)
		//		_logger.LogInformation($"Successfully retrieved {storedProcedures.Count} stored procedures");
		//	else
		//		_logger.LogWarning(">> We were unable to retrieve ANY stored procedures from SQL!!! <<");

		//	Console.WriteLine();
		//}

		//public void Test_InsertSingleWithStoredProcedure()
		//{
		//	_logger.LogInformation("Attempting to insert a single record into SQL");

		//	StoredProcedureDefinition spDefinition = new StoredProcedureDefinition()
		//	{
		//		Name = "usp_CAE1468_AssessmentManager_InsertQuestion",
		//		Parameters = _databaseUtility.BuildParameterList(new Dictionary<string, string>()
		//		{
		//			["question_text"] = "BEN QuestionText",
		//			["source_identifier"] = "BEN SourceIdentifier"
  //              })
		//	};

		//	var result = _databaseManager.RunStoredProcedureWrite(spDefinition);

		//	if ((int)result > 0)
		//		_logger.LogInformation($"Successfully inserted a single record into SQL");
		//	else
		//		_logger.LogWarning(">> We were unable to insert any records into SQL!!! <<");
		//}
	}
}

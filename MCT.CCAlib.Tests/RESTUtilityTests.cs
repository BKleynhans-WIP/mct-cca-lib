using MCT.CCAlib.Interfaces;
using MCT.CCAlib.Utilities;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Xunit;

namespace MCT.CCAlib.Tests
{
    public class RESTUtilityTests
    {
        //private RESTConfig _restConfig;
        //private SQLConfig _sqlConfig;

        //public RESTUtilityTests()
        //{
        //    LibConfig libConfig = new LibConfig(new Logger("MCT.CCAlib.Tests"));
        //    var appConfig = libConfig.GetConfig<AppConfig>("debug");
        //    _restConfig = appConfig.REST;
        //    _sqlConfig = appConfig.SQL;
        //}

        //[Fact]
        //public void TestRESTUtility_Get()
        //{
        //    //subscriber id: 203436306
        //    Mock<ISqlDatabaseUtility> mockSQLUtility = new Mock<ISqlDatabaseUtility>();
        //    mockSQLUtility.Setup(t => t.ExecuteReaderQuery(It.IsAny<ISqlDatabaseUtility.QueryType>(), It.IsAny<string>(), It.IsAny<string>())).Returns(GetJwtTables());
        //    SQLManager sqlManager = new SQLManager(mockSQLUtility.Object, new Logger("MCT.CCAlib.Tests"));

        //    IApiUtility restUtility = new RESTUtility(_restConfig, sqlManager);

        //    ApiResponse apiResponse = restUtility.Get("members/2-176132000/concepts?ids=503217,501618").Result;

        //    Assert.True(apiResponse.IsSuccess);
        //}


        //[Fact(Skip = "will create an actual task")]
        ////[Fact]
        //public void TestRESTUtility_Post()
        //{
        //    //subscriber id: 203211857
        //    var dueDate = DateTime.Today;
        //    var jsonRequest = "{\"type\":\"Reminder\",\"assignedTo\":{\"userId\":\"2-ccrackne\",\"queueId\":\"\"},\"priority\":\"Medium\",\"dueDate\":\""+ dueDate + "\",\"subject\":\"CCA Lib Unit Test - POST\",\"memberId\":\"2-164344650\"}";

        //    Mock<ISqlDatabaseUtility> mockSQLUtility = new Mock<ISqlDatabaseUtility>();
        //    mockSQLUtility.Setup(t => t.ExecuteReaderQuery(It.IsAny<ISqlDatabaseUtility.QueryType>(), It.IsAny<string>(), It.IsAny<string>())).Returns(GetJwtTables());
        //    SQLManager sqlManager = new SQLManager(mockSQLUtility.Object, new Logger("MCT.CCAlib.Tests"));

        //    IApiUtility restUtility = new RESTUtility(_restConfig, sqlManager);

        //    ApiResponse apiResponse = restUtility.Post("tasks", jsonRequest).Result;

        //    Assert.True(apiResponse.IsSuccess);
        //}

        //[Fact(Skip = "will create an actual task")]
        ////[Fact]
        //public void TestRESTUtility_Put()
        //{
        //    //subscriber id: 203211857
        //    var dueDate = DateTime.Today.AddMonths(1);
        //    var jsonRequest = "{\"dueDate\":\""+ dueDate +"\",\"reason\":\"CCA Lib Unit Test - PUT\"}";

        //    Mock<ISqlDatabaseUtility> mockSQLUtility = new Mock<ISqlDatabaseUtility>();
        //    mockSQLUtility.Setup(t => t.ExecuteReaderQuery(It.IsAny<ISqlDatabaseUtility.QueryType>(), It.IsAny<string>(), It.IsAny<string>())).Returns(GetJwtTables());
        //    SQLManager sqlManager = new SQLManager(mockSQLUtility.Object, new Logger("MCT.CCAlib.Tests"));

        //    IApiUtility restUtility = new RESTUtility(_restConfig, sqlManager);

        //    ApiResponse apiResponse = restUtility.Put("tasks/357696/dueDate", jsonRequest).Result;

        //    Assert.True(apiResponse.IsSuccess);
        //}

        //[Fact]
        //public void TestRESTUtility_EmptyRequest()
        //{
        //    Mock<ISqlDatabaseUtility> mockSQLUtility = new Mock<ISqlDatabaseUtility>();
        //    mockSQLUtility.Setup(t => t.ExecuteReaderQuery(It.IsAny<ISqlDatabaseUtility.QueryType>(), It.IsAny<string>(), It.IsAny<string>())).Returns(GetJwtTables());

        //    SQLManager sqlManager = new SQLManager(mockSQLUtility.Object, new Logger("MCT.CCAlib.Tests"));

        //    var jsonRequest = "";
        //    IApiUtility restUtility = new RESTUtility(_restConfig, sqlManager);

        //    ApiResponse apiResponse = restUtility.Post("tasks", jsonRequest).Result;

        //    Assert.False(apiResponse.IsSuccess);
        //}

        //[Fact]
        //public void TestRESTUtility_EmptyJwtTables()
        //{
        //    Mock<ISqlDatabaseUtility> mockSQLUtility = new Mock<ISqlDatabaseUtility>();
        //    mockSQLUtility.Setup(t => t.ExecuteReaderQuery(It.IsAny<ISqlDatabaseUtility.QueryType>(), It.IsAny<string>(), It.IsAny<string>())).Returns(GetEmptyJwtTables());
        //    SQLManager sqlManager = new SQLManager(mockSQLUtility.Object, new Logger("MCT.CCAlib.Tests"));

        //    var jsonRequest = "{\"type\":\"Reminder\",\"assignedTo\":{\"userId\":\"2-ccrackne\",\"queueId\":\"\"},\"priority\":\"Medium\",\"dueDate\":\"2022-03-19\",\"subject\":\"CCA Lib Unit Test\",\"memberId\":\"2-114936150\"}";
        //    IApiUtility restUtility = new RESTUtility(_restConfig, sqlManager);

        //    ApiResponse apiResponse = restUtility.Post("tasks", jsonRequest).Result;

        //    Assert.False(apiResponse.IsSuccess);
        //}

        //public static DataSet GetJwtTables()
        //{
        //    DataSet ds = new DataSet();
        //    DataTable config = CreateAppConfigTable();
        //    LoadAppConfigTable(ref config);
        //    DataTable jwt = CreateJWTTable();
        //    LoadJWTTable(ref jwt);
        //    ds.Tables.Add(config);
        //    ds.Tables.Add(jwt);

        //    return ds;
        //}

        //public static DataSet GetEmptyJwtTables()
        //{
        //    DataSet ds = new DataSet();
        //    DataTable config = CreateAppConfigTable();
        //    DataTable jwt = CreateJWTTable();
        //    ds.Tables.Add(config);
        //    ds.Tables.Add(jwt);

        //    return ds;
        //}

        //private static DataTable CreateAppConfigTable()
        //{
        //    DataTable dt = new DataTable("AppConfig");
        //    dt.Columns.Add("value", typeof(string));

        //    return dt;
        //}

        //private static void LoadAppConfigTable(ref DataTable dt)
        //{
        //    dt.Rows.Add("https://caedevwwv02.excellus.com");
        //}

        //private static DataTable CreateJWTTable()
        //{
        //    DataTable dt = new DataTable("JWT");
        //    dt.Columns.Add("iss", typeof(string));
        //    dt.Columns.Add("key", typeof(string));

        //    return dt;
        //}


        //private static void LoadJWTTable(ref DataTable dt)
        //{
        //    dt.Rows.Add("cae", "vXt3W1XYvOffnfuZCOBub0cF7KtG9fJYT+iaswdd");
        //}
    }
}

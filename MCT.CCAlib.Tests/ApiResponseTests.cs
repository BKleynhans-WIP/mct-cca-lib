using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MCT.CCAlib.Tests
{
	public class ApiResponseTests
	{
		//[Fact]
		//public void TestApiResponse_Message_FormattedJson() 
		//{
		//	ApiResponse apiResponse = new ApiResponse()
		//	{
		//		IsSuccess = true,
		//		Message = "{\"id\":\"357061\",\"href\":\"https://caedevwwv02.excellus.com:447/userapi/v1/tasks/357062\"}"
		//	};

		//	var message = apiResponse.GetJsonFormattedMessage();

		//	Assert.Equal("{\r\n  \"id\": \"357061\",\r\n  \"href\": \"https://caedevwwv02.excellus.com:447/userapi/v1/tasks/357062\"\r\n}", message);
		//}

		//[Fact]
		//public void TestApiResponse_Message_IdFieldValue() 
		//{
		//	ApiResponse apiResponse = new ApiResponse()
		//	{
		//		IsSuccess = true,
		//		Message = "{\"id\":\"2412504\",\"href\":null}"
		//	};

		//	var id = apiResponse.GetIdFromResponse();

		//	Assert.Equal("2412504", id);
		//}

		//[Fact]
		//public void TestApiResponse_Message_400Error()
		//{
		//	ApiResponse apiResponse = new ApiResponse()
		//	{
		//		IsSuccess = false,
		//		Message = "{\"errors\":{\"Name\":[\"The Name field is required.\"]},\"type\":\"https://tools.ietf.org/html/rfc7231#section-6.5.1\",\"title\":\"One or more validation errors occurred.\",\"status\":400,\"traceId\":\"|1f96fbc5-4b8547f4f148425f.\"}"
		//	};

		//	var error = apiResponse.GetErrorMessage();

		//	Assert.Equal("The Name field is required.", error);
		//}

		//[Fact]
		//public void TestApiResponse_Message_Non400Error() 
		//{
		//	ApiResponse apiResponse = new ApiResponse()
		//	{
		//		IsSuccess = false,
		//		Message = "{\"type\":\"https://tools.ietf.org/html/rfc7231#section-6.5.4\",\"title\":\"Not Found\",\"status\":404,\"detail\":\"Member not found.\",\"traceId\":\"|c34f3bd5-447a4bb69d326d32.\"}"
		//	};

		//	var error = apiResponse.GetErrorMessage();

		//	Assert.Equal("Member not found.", error);
		//}
	}
}

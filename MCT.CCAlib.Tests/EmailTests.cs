using MCT.CCAlib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MCT.CCAlib.Tests
{
	public class EmailTests
	{
		//private LibConfig _libConfig;
		//private Email _email;
		//private string _recipientDev = "christina.cracknell@excellus.com";

		//public EmailTests()
		//{
		//	_libConfig = new LibConfig(new Logger("MCT.CCAlib.Tests"));
		//	var appConfig = _libConfig.GetConfig<AppConfig>("debug");
		//	_email = new Email(appConfig.Email);
		//}

		//[Fact]
		//public void TestSendEmail_NoRecipients()
		//{
		//	bool isSent = _email.SendEmail(null, "Test No Recipients", "Testing email fails to send with no recipients");

		//	Assert.False(isSent);
		//}

		//[Fact(Skip = "update receipient list before sending email")]
		////[Fact]
		//public void TestSendEmail_ToRecipients()
		//{
		//	List<string> recipients = new List<string>() { _recipientDev };

		//	bool isSent = _email.SendEmail(recipients, "Test TO", "Testing TO Recipients");

		//	Assert.True(isSent);
		//}

		//[Fact(Skip = "update receipient list before sending email")]
		////[Fact]
		//public void TestSendEmail_MultipleToRecipients()
		//{
		//	List<string> recipients = new List<string>() { _recipientDev, _recipientDev };

		//	bool isSent = _email.SendEmail(recipients, "Test Multiple TO Recipients", "Testing Multiple TO Recipients");

		//	Assert.True(isSent);
		//}

		//[Fact(Skip = "update receipient list before sending email")]
		////[Fact]
		//public void TestSendEmail_ToCcBccRecipients()
		//{
		//	List<string> recipients = new List<string>() { _recipientDev };
		
		//	bool isSent = _email.SendEmail(recipients, recipients, recipients, "Test TO CC BCC", "Testing TO, CC and BCC Recipients");

		//	Assert.True(isSent);
		//}

		//[Fact(Skip = "update receipient list before sending email")]
		////[Fact]
		//public void TestSendEmail_ToCcRecipients()
		//{
		//	List<string> recipients = new List<string>() { _recipientDev };

		//	bool isSent = _email.SendEmail(recipients, recipients, null, "Test TO CC", "Testing TO and CC Recipients");

		//	Assert.True(isSent);
		//}

		//[Fact(Skip = "update receipient list before sending email")]
		////[Fact]
		//public void TestSendEmail_ToBccRecipients()
		//{
		//	List<string> recipients = new List<string>() { _recipientDev };

		//	bool isSent = _email.SendEmail(recipients, null, recipients, "Test TO BCC", "Testing TO and BCC Recipients");

		//	Assert.True(isSent);
		//}

		//[Fact(Skip = "update receipient list before sending email")]
		////[Fact]
		//public void TestSendEmail_MultipleCcRecipients()
		//{
		//	List<string> recipients = new List<string>() { _recipientDev, _recipientDev };

		//	bool isSent = _email.SendEmail(null, recipients, null, "Test Multiple CC Recipients", "Testing Multiple CC Recipients");

		//	Assert.True(isSent);
		//}

		//[Fact(Skip = "update receipient list before sending email")]
		////[Fact]
		//public void TestSendEmail_BccRecipients()
		//{
		//	List<string> recipients = new List<string>() { _recipientDev };

		//	bool isSent = _email.SendEmail(null, null, recipients, "Test BCC Only", "Testing BCC Recipients Only");

		//	Assert.True(isSent);
		//}

		//[Fact(Skip = "update receipient list before sending email")]
		////[Fact]
		//public void TestSendEmail_WithAttachmentNoName()
		//{
		//	List<string> recipients = new List<string>() { _recipientDev };

		//	byte[] buffer = Encoding.ASCII.GetBytes("The quick brown fox jumps over the lazy dog");
		//	bool isSent = _email.SendEmail(recipients, null, null, "Test No Attachment Name", "Testing email sent without attachment because it didn't have a name specified.", buffer, "");;

		//	Assert.True(isSent);
		//}

		//[Fact(Skip = "update receipient list before sending email")]
		////[Fact]
		//public void TestSendEmail_WithAttachment()
		//{
		//	List<string> recipients = new List<string>() { _recipientDev };

		//	byte[] buffer = Encoding.ASCII.GetBytes("The quick brown fox jumps over the lazy dog");
		//	bool isSent = _email.SendEmail(recipients, null, null, "Test Attachment", "Testing email sent with attachment (BrownFox.txt)", buffer, "BrownFox.txt");


		//	Assert.True(isSent);
		//}
	}
}

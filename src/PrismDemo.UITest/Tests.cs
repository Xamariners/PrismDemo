using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace PrismDemo.UITest
{
	[TestFixture]
	public class Tests
	{
		iOSApp _app;
        iOSQueries _queries;

		[SetUp]
		public void BeforeEachTest()
		{
			_app = ConfigureApp
				.iOS
				// TODO: Update this path to point to your iOS app and uncomment the
				// code if the app is not included in the solution.
				//.AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/PrismDemo.iOS.app")
				.StartApp();

			_queries = new iOSQueries(_app);
		}

		[Test]
		public void AppLaunches()
		{
			_app.Screenshot("First screen.");
		}

		[Test]
		public void PushButton()
		{
			_queries.TapOnButtonMarked("+ Add new Todo Item");

			_queries.ValidateLabelText("Todo Item Title:");
			_queries.ValidateLabelText("Todo Item Description:");
			_queries.ValidateLabelText("Current Status:");
		}
	}
}

using System;
using System.Linq;


namespace PrismDemo.UITest
{
	using Xamarin.UITest;
	using Xamarin.UITest.Queries;

	public class iOSQueries
    {
		private readonly IApp _app; 
		public iOSQueries(IApp app)
		{
			_app = app;
		}

        public AppResult[] WaitForElementMarked(string mark, string timeoutMessage = "not found", int timeout=5)
        {
            return _app.WaitForElement(mark, timeoutMessage, TimeSpan.FromSeconds(timeout));
        }

        public AppResult[] WaitForLabelText(string text, string timeoutMessage, int timeout)
        {
			return _app.WaitForElement(c => c.Class("UILabel").Marked(text), timeoutMessage, TimeSpan.FromSeconds(timeout));
        }

		public AppResult[] WaitForTextFieldText(string text, string timeoutMessage, int timeout)
		{
			return _app.WaitForElement(c => c.Class("UITextField").Marked(text), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForTextFieldLabelMarked(string marked, string timeoutMessage, int timeout)
		{
			return _app.WaitForElement(c => c.Class("UITextFieldLabel").Marked(marked), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForWindowMarked(string mark, string timeoutMessage, int timeout)
		{
			return _app.WaitForElement(mark, timeoutMessage, TimeSpan.FromSeconds(timeout));
			//return _app.WaitForElement(c => c.Class("UIWindow").Marked(mark), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForButtonMarked(string mark, string timeoutMessage, int timeout)
		{
			return _app.WaitForElement(c => c.Class("UIButton").Marked(mark), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForButtonLabelText(string parentMark, string text, string timeoutMessage, int timeout)
		{
			return _app.WaitForElement(c => c.Class("UIButton").Marked(parentMark).Child("UIButtonLabel").Text(text), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

        public AppResult[] WaitForNavigationBarText(string accessibilityLabel, string timeoutMessage, int timeout)
        {
            return _app.WaitForElement(c => c.Class("UINavigationBar").Id(accessibilityLabel), timeoutMessage, TimeSpan.FromSeconds(timeout));
        }

		public AppResult[] WaitForLabelContainingText(string text, string timeoutMessage, int timeout)
		{
			return _app.WaitForElement(c => c.Class("UILabel").Property("text").Contains(text), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForDescendantButtonAtIndex(string parentMark, int index, string buttonMark, string timeoutMessage, int timeout)
		{
			return _app.WaitForElement(c => c.Marked(parentMark).Index(index).Descendant().Marked(buttonMark).Class("UIButton"), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForDescendantLabelAtIndex(string parentMark, int index, string labelMark, string timeoutMessage, int timeout)
		{
			return _app.WaitForElement(c => c.Marked(parentMark).Index(index).Descendant().Marked(labelMark).Class("UILabel"), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

        public void EnterTextOnElementMarked(string mark, string text)
        {
			TapOnElementMarked(mark);
            _app.EnterText(mark, text);
        }

        public void TapOnElementMarked(string mark)
        {
			WaitForElementMarked(mark, $"'{mark}' does not exist", 5);
            _app.Tap(mark);
        }

		public void TapOnButtonMarked(string mark)
        {
			WaitForElementMarked(mark, $"'button {mark}' does not exist", 5);


			// check if keyboard and tap if there is to dismiss it
			var keyboard = _app.Query(x => x.Class("UIKBKeyView"));

			if(keyboard?.Count() > 0)  
				_app.Tap(mark);

			_app.Tap(mark);
        }

		public void ValidateLabelMarked(string mark)
		{
			var result = WaitForElementMarked (mark, $"'{mark}' does not exist", 30);
			result[0].Id.ShouldEqual (mark);
		}

		public void ValidateLabelText(string text)
		{
			var result = WaitForLabelText (text, $"'{text}' does not exist", 30);
			result[0].Text.ShouldContain(text);
		}

		public void ValidateWindowMarked(string mark)
		{
			var result = WaitForWindowMarked (mark, $"'{mark}' does not exist", 60);
			result[0].Id.ShouldEqual (mark);
		}

		public void ValidateButtonMarked(string mark)
		{
			var result = WaitForButtonMarked (mark, $"'{mark}' does not exist", 5);
			result[0].Id.ShouldEqual (mark);

		}

		public void ValidateButtonText(string text)
		{
			var result = WaitForButtonMarked (text, $"'{text}' does not exist", 5);

			if(result[0].Text != null)
				result[0].Text.ShouldEqual (text);
			else
				result [0].Label.ShouldEqual (text);
			
		}

		public void ValidateNavId(string id)
		{
			var result = WaitForNavigationBarText (id, $"'{id}' does not exist", 5);
			result[0].Id.ShouldEqual (id);
		}

		public void ValidateTextField(string mark, string watermark  = "")
		{
			var result = WaitForTextFieldLabelMarked(mark, $"'{mark}' does not exist", 5);
			result [0].Text.ShouldEqual (mark);

			//if(! string.IsNullOrEmpty(watermark))
			//{
			//	var result2 = WaitForTextFieldText(watermark, string.Format ("'{0}' does not exist", watermark), 5);
			//	result2 [0].Label.ShouldEqual (watermark);
			//}
		}

		// pass -1 as index to tap on last marked button
		public void TapOnButtonMarked(string mark, int index)
		{
			WaitForButtonMarked(mark, $"'{mark}' does not exist", 5);
			if (index == -1)
				index = _app.Query(c => c.Class("UIButton").Marked(mark)).Length - 1;
			_app.Tap(c => c.Class("UIButton").Marked(mark).Index(index));
		}

		public void ValidateMessageContainingText(string text)
		{
			var result = WaitForLabelContainingText(text, $"label containing '{text}' does not exist", 30);
			result[0].Text.ShouldContain(text);
		}

		// pass -1 as index to find descendant inside the last element with Id = id
		public void ValidateDescendantButtonAtIndex(string parentMark, int index, string buttonMark)
		{
			if (index == -1)
				index = _app.Query(c => c.Marked(parentMark)).Length - 1;
			var result = WaitForDescendantButtonAtIndex(parentMark, index, buttonMark, $"'{buttonMark}' does not exist", 30);
			result[0].Class.Equals("UIButton");
			result[0].Label.Equals(buttonMark);
		}

		// pass -1 as index to find descendant inside the last element with Id = id
		public void ValidateDescendantLabelAtIndex(string parentMark, int index, string labelMark)
		{
			if (index == -1)
				index = _app.Query(c => c.Marked(parentMark)).Length - 1;
			var result = WaitForDescendantLabelAtIndex(parentMark, index, labelMark, $"'{labelMark}' does not exist", 30);
			result[0].Class.Equals("UILabel");
			result[0].Label.Equals(labelMark);
		}

		public void ScrollToScreenBottom()
		{
			_app.ScrollDown(c => c.Class("UIScrollView"), ScrollStrategy.Gesture, 0.95, 100000, false);
		}
			
	}
}

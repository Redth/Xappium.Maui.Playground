using Xappium.UITest;
using Xunit;

namespace UITests
{
	public class Tests : XappiumTestBase
	{
		[Fact]
		public void Click_Button_Increments_Counter()
		{
			var e = Engine.WaitForElementWithText("Click me");

			Engine.TapWithText("Click me");

			var c = Engine.WaitForElementWithText("Current count: 1");

			Assert.NotNull(c);
			Assert.Equal("Current count: 1", c.Text);
		}
	}
}
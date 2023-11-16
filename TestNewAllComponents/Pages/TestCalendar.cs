using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NewAllComponents.Pages;

namespace TestNewAllComponents
{
	[Collection("NewAllComponents")]
	public class TestCalendar
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCalendarModule));
			var componentUnderTest = ctx.RenderComponent<Calendar>();
			Assert.NotNull(componentUnderTest);
		}
	}
}

using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NewAllComponents.Pages;
using NewAllComponents.Financial;
using NewAllComponents.Northwind;

namespace TestNewAllComponents
{
	[Collection("NewAllComponents")]
	public class TestView_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbTabsModule),
				typeof(IgbAccordionModule),
				typeof(IgbExpansionPanelModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbStepperModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbTreeModule),
				typeof(IgbIconButtonModule),
				typeof(IgbBadgeModule),
				typeof(IgbChipModule),
				typeof(IgbCheckboxModule),
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule),
				typeof(IgbSwitchModule),
				typeof(IgbRatingModule),
				typeof(IgbSliderModule),
				typeof(IgbInputModule),
				typeof(IgbDatePickerModule),
				typeof(IgbSelectModule),
				typeof(IgbComboModule),
				typeof(IgbCalendarModule),
				typeof(IgbCardModule),
				typeof(IgbCategoryChartModule),
				typeof(IgbGridModule),
				typeof(IgbSnackbarModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<View_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}

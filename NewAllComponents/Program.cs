using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NewAllComponents;
using NewAllComponents.Financial;
using NewAllComponents.Northwind;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IFinancialService, FinancialService>();
builder.Services.AddScoped<INorthwindService, NorthwindService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbTabsModule),
        typeof(IgbAccordionModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbStepperModule),
        typeof(IgbButtonModule),
        typeof(IgbTreeModule),
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
        typeof(IgbSnackbarModule)
    );
}
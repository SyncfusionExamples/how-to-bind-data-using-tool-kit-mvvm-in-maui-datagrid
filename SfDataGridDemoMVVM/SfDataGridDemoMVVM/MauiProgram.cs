using CommunityToolkit.Maui;
using SfDataGridDemoMVVM.ViewModel;
using Syncfusion.Maui.Core.Hosting;

namespace SfDataGridDemoMVVM;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<MainPage>();
	
		return builder.Build();
	}
}

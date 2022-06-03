using MauiApp1.ViewModels;
using MauiApp1.VIews;

namespace MauiApp1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Register Platform Specific
		//builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

		// Register Navigation
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainPageViewModel>();

		builder.Services.AddTransient<Page1>();
		builder.Services.AddTransient<Page1ViewModel>();

		builder.Services.AddTransient<Page2>();
		builder.Services.AddTransient<Page2ViewModel>();

		return builder.Build();
	}
}
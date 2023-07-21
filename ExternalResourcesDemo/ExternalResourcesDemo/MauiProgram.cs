using Microsoft.Extensions.Logging;

namespace ExternalResourcesDemo;

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
                fonts.AddFont("Balisay.ttf", "Balisay");
                fonts.AddFont("GoldenRecord_PERSONAL_USE_ONLY.otf", "GoldenRecord_PERSONAL_USE_ONLY");
                fonts.AddFont("GoldenRecordOutl_PERSONAL_USE_ONLY.otf", "GoldenRecordOutl_PERSONAL_USE_ONLY");
                fonts.AddFont("fontello.ttf", "Icons");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}


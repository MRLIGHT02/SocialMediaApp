using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace SocialMediaApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Ubuntu-Regular.ttf", "Ubuntu-Regular");
				fonts.AddFont("Ubuntu-Bold.ttf", "Ubuntu-Bold");
				
			})
            .UseMauiCommunityToolkit();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

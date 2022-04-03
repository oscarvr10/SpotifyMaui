namespace SpotifyMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("circular-bold.ttf", "CircularSpotifyTxT-Bold");
				fonts.AddFont("circular-book.ttf", "CircularSpotifyTxT-Book");
				fonts.AddFont("circular-medium.ttf", "CircularSpotifyTxT-Med");
				fonts.AddFont("FontIcons.ttf", "MdIcons");
			});

		return builder.Build();
	}
}

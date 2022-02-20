using SpotifyMaui.Views;

namespace SpotifyMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new BaseShellView();

		Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
		Routing.RegisterRoute(nameof(SearchView), typeof(SearchView));
		Routing.RegisterRoute(nameof(MyLibraryView), typeof(MyLibraryView));
	}
}

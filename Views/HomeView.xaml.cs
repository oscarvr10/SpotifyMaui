using SpotifyMaui.ViewModels;

namespace SpotifyMaui.Views;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
	}
}
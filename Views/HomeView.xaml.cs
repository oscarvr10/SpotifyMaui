namespace SpotifyMaui.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
    }
}
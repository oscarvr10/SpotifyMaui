namespace SpotifyMaui.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class SearchView : ContentPage
{	
	public SearchView()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
	}
}
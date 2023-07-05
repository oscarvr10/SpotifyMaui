namespace SpotifyMaui.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class MyLibraryView : ContentPage
{
	public MyLibraryView()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
	}
}
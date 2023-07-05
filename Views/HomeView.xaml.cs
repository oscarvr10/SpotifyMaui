namespace SpotifyMaui.Views;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    void recentsCollectionView_SizeChanged(System.Object sender, System.EventArgs e)
    {

    }
}
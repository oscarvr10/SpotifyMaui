using SpotifyMaui.Models;
using SpotifyMaui.Resources.Strings;
using SpotifyMaui.Views;

namespace SpotifyMaui.ViewModels;

public class BaseShellViewModel
{
    public AppSection Home { get; set; }
    public AppSection Search { get; set; }
    public AppSection MyLibrary { get; set; }

    public BaseShellViewModel()
    {
        Home = new AppSection() { Title = StringResources.HomeTitle, Icon = "home.png", TargetType = typeof(HomeView) };
        Search = new AppSection() { Title = StringResources.SearchTitle, Icon = "search.png", TargetType = typeof(SearchView) };
        MyLibrary = new AppSection() { Title = StringResources.MyLibraryTitle, Icon = "library.png", TargetType = typeof(MyLibraryView) };
    }
}

using SpotifyMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyMaui.ViewModels
{
    public class BaseShellViewModel
    {
        public AppSection Home { get; set; }
        public AppSection Search { get; set; }
        public AppSection MyLibrary { get; set; }

        public BaseShellViewModel()
        {
            //Home = new AppSection() { Title = AppResource.HomeTitle, Icon = "home.png", TargetType = typeof(HomeView) };
            //Search = new AppSection() { Title = AppResource.SearchTitle, Icon = "search.png", TargetType = typeof(SearchView) };
            //MyLibrary = new AppSection() { Title = AppResource.MyLibraryTitle, Icon = "library.png", TargetType = typeof(MyLibraryView) };
        }
    }
}

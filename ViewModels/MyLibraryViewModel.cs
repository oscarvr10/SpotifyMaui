using SpotifyMaui.Models;
using SpotifyMaui.Services;
using SpotifyMaui.ViewModels.Base;

namespace SpotifyMaui.ViewModels
{
    public  class MyLibraryViewModel : ViewModelBase
    {
        List<Playlist> _playlists;
        public List<Playlist> Playlists
        {
            get { return _playlists; }
            set
            {
                _playlists = value;
                OnPropertyChanged();
            }
        }

        List<CategoryItem> _categoryItems;
        public List<CategoryItem> CategoryItems
        {
            get { return _categoryItems; }
            set
            {
                _categoryItems = value;
                OnPropertyChanged();
            }
        }

        public MyLibraryViewModel()
        {
            Playlists = MockDataService.GetPlaylists();
            CategoryItems = new List<CategoryItem>
            {
                new CategoryItem{Name = "Playlists"},
                new CategoryItem{Name = "Podcasts & Shows"},
                new CategoryItem{Name = "Albums"},
                new CategoryItem{Name = "Artists"},
                new CategoryItem{Name = "Downloads"}
            };
        }
    }
}

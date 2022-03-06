using SpotifyMaui.Models;
using SpotifyMaui.Services;
using SpotifyMaui.ViewModels.Base;

namespace SpotifyMaui.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        List<Recent> _recents;
        public List<Recent> Recents
        {
            get { return _recents; }
            set
            {
                _recents = value;
                OnPropertyChanged();
            }
        }

        List<Album> _albums;
        public List<Album> Albums
        {
            get { return _albums; }
            set
            {
                _albums = value;
                OnPropertyChanged();
            }
        }

        List<Song> _songs;
        public List<Song> Songs
        {
            get { return _songs; }
            set
            {
                _songs = value;
                OnPropertyChanged();
            }
        }
        public HomeViewModel()
        {
            InitData();
        }

        public void InitData()
        {
            Recents = MockDataService.GetRecents();
            Albums = MockDataService.GetAlbums();
            Songs = MockDataService.GetSongs();
        }
    }
}

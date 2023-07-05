using SpotifyMaui.Models;
using SpotifyMaui.Services;
using SpotifyMaui.ViewModels.Base;

namespace SpotifyMaui.ViewModels;

public class SearchViewModel : ViewModelBase
{
    List<SearchCategory> _searchCategories;
    public List<SearchCategory> SearchCategories
    {
        get { return _searchCategories; }
        set
        {
            _searchCategories = value;
            OnPropertyChanged();
        }
    }

    public SearchViewModel()
    {
        SearchCategories = MockDataService.GetSearchCategories();
    }
}

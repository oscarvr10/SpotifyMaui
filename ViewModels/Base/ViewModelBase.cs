﻿namespace SpotifyMaui.ViewModels.Base;

public class ViewModelBase : BindableObject
{
    public virtual Task InitializeAsync(object navigationData)
    {
        return Task.FromResult(false);
    }
}

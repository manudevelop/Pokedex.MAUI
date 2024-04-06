using System.Runtime.CompilerServices;

namespace Pokedex.MAUI.Views;

public abstract class BaseContentView : ContentView
{
    public bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
            return false;

        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}
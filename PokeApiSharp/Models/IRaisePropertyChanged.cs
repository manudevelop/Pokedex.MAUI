using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PokeApiSharp.Models
{
    public interface IRaisePropertyChanged : INotifyPropertyChanged
    {
        void OnPropertyChanged([CallerMemberName] string propertyName = null);
        bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null);
    }
}

using System.Collections.ObjectModel;

namespace MyApp
{
    public class MainViewModel : BindableObject
    {
        public ObservableCollection<MyViewModel> Items { get; } = new ObservableCollection<MyViewModel>();

        public MainViewModel()
        {
            // Agregar algunos elementos de ejemplo
            Items.Add(new MyViewModel { ItemText = "Elemento 1" });
            Items.Add(new MyViewModel { ItemText = "Elemento 2" });
            Items.Add(new MyViewModel { ItemText = "Elemento 3" });
        }
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}

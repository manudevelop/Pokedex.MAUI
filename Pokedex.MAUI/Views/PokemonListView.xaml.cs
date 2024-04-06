using Pokedex.Core.ViewModels;

namespace Pokedex.MAUI.Views;

public partial class PokemonListView : ContentView
{
    public PokemonListViewModel ViewModel { get; set; }
    public PokemonListView()
	{
		InitializeComponent();
        ViewModel = new PokemonListViewModel();
        BindingContext = ViewModel;

        Loaded += RefreshEvent;
        SizeChanged += PokemonListView_SizeChanged;
    }

    private void PokemonListView_SizeChanged(object? sender, EventArgs e)
    {
        double windowWidth = this.Width;
        int numColumns = (int)(windowWidth / 300); 
        numColumns = Math.Max(numColumns, 1);
        ((GridItemsLayout)collectionView.ItemsLayout).Span = numColumns;
    }

    private async void RefreshEvent(object? sender, EventArgs e)
           => await ViewModel.RefreshDataAsync();

    private async void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        if(e.LastVisibleItemIndex == ViewModel.Items.Count -1)
            await ViewModel.RefreshDataAsync();
    }
}
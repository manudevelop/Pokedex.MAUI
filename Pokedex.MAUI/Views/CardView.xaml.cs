using PokeApiSharp.Models;
using Pokedex.Core.ViewModels;
using System.Runtime.CompilerServices;

namespace Pokedex.MAUI.Views;

public partial class CardView : BaseContentView
{
    public static readonly BindableProperty ViewModelProperty =
        BindableProperty.Create(nameof(ViewModel), typeof(Pokemon), typeof(CardView), null);

    public PokemonDetailViewModel ViewModel
    { 
        get => (PokemonDetailViewModel)GetValue(ViewModelProperty); 
        set => SetValue(ViewModelProperty, value); 
    }

    public CardView()
    {
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            if (FrontCard.IsVisible)
            {
                BackCard.RotationY = -90;
                await FrontCard.RotateYTo(90, 1 * 500);
                
                FrontCard.IsVisible = false;
                BackCard.IsVisible = true;
                
                await BackCard.RotateYTo(0, 1 * 500);
                FrontCard.RotationY = 0;
            }
            else
            {
                FrontCard.RotationY = -90;
                await BackCard.RotateYTo(90, 1 * 500);

                BackCard.IsVisible = false;
                FrontCard.IsVisible = true;

                await FrontCard.RotateYTo(0, 1 * 500);
                BackCard.RotationY = 0;
            }
        }
        catch (Exception ex)
        {
        }

    }
}
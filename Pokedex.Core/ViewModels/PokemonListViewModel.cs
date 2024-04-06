using PokeApiSharp.Models;
using PokeApiSharp.Repositories;
using System.Collections.ObjectModel;

namespace Pokedex.Core.ViewModels
{
    public class PokemonListViewModel : BaseViewModel
    {
        int _lastOffset = 0;
        bool _waited = false;

        public ObservableCollection<PokemonDetailViewModel> Items { get; set; }

        public PokemonListViewModel()
        {
            Items = new ObservableCollection<PokemonDetailViewModel>();
        }

        public async Task RefreshDataAsync()
        {
            if (_waited)
                return;

            _waited = true;

            PokemonApiRepositories repositories = new PokemonApiRepositories();
            var pokemons = await repositories.Pokemons.GetAllAsync(_lastOffset, 10);
              
            _lastOffset += 10;

            foreach (var pokemon in pokemons.results)
            {
                var detailViewModel = new PokemonDetailViewModel();
                await detailViewModel.RefreshDataAsync(pokemon.name);
                Items.Add(detailViewModel);
            }

            _waited = false;
        }
    }
}

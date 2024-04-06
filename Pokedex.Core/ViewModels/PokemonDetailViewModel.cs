using PokeApiSharp.Models;
using PokeApiSharp.Repositories;
using System.Collections.ObjectModel;

namespace Pokedex.Core.ViewModels
{

    public class PokemonDetailViewModel : BaseViewModel
    {
        Pokemon _pokemon;
        public Pokemon Pokemon { 
            get => _pokemon; 
            set => SetProperty(ref _pokemon,value); 
        }

        Specie _specie;
        public Specie Specie { 
            get => _specie; 
            set => SetProperty(ref _specie, value); 
        }


        ObservableCollection<Auxiliar.Lang> _types;
        public ObservableCollection<Auxiliar.Lang> Types
        {
            get => _types;
            set => SetProperty(ref _types, value);
        }

        public PokemonDetailViewModel()
        {
            Types = new ObservableCollection<Auxiliar.Lang>();
        }

        public async Task RefreshDataAsync(string pokemonName)
        {
            PokemonApiRepositories repositories = new PokemonApiRepositories();

            Pokemon = await repositories.Pokemons.GetAsync(pokemonName);
            Specie = await repositories.Species.GetAsync(Pokemon.species.name);

            foreach (var pokemonType in Pokemon.types)
            {
                var type = await repositories.Types.GetAsync(pokemonType.type.name);
                var type_es = type.names.FirstOrDefault(p => p.language.name == "es");

                if(type_es != null)
                    Types.Add(type_es);
            }
        }
    }
}

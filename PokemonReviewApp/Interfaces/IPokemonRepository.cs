using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        ICollection<Pokemon> GetPokemons();
        decimal GetPokemonRating(int id);
        bool PokemonExist(int pokeId);
    }
}

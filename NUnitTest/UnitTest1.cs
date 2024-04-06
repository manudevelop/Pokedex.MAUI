using PokeApiSharp.Repositories;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            PokemonRepository repository = new PokemonRepository();
            var pokemon = await repository.GetAsync("ditto");
            Assert.Pass();
        }


        [Test]
        public async Task Test2()
        {
            SpecieRepository repository = new SpecieRepository();
            var item = await repository.GetAsync(1);
            Assert.Pass();
        }
    }
}
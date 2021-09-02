using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Tournament")
                {
                    break;
                }

                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer currenTrainer = new Trainer(trainerName);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = currenTrainer;
                }
                trainers[trainerName].Pokemons.Add(currentPokemon);
            }

            while (true)
            {
                string element = Console.ReadLine();
                if (element == "End")
                {
                    break;
                }

                foreach (var (name, trainer) in trainers)
                {
                    bool havePokemon = false;
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == element)
                        {
                            trainer.Badges += 1;
                            havePokemon = true;
                            break;
                        }
                    }

                    if (havePokemon == false)
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            if (trainer.Pokemons[i].Health > 10)
                            {
                                trainer.Pokemons[i].Health -= 10;
                            }
                            else
                            {
                                trainer.Pokemons.Remove(trainer.Pokemons[i]);
                                i--;
                            }
                        }
                    }
                }
            }

            foreach (var (name, trainer) in trainers
                                            .OrderByDescending(t => t.Value.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }

        }
    }
}

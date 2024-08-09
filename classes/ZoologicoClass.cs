using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Interface;

namespace Zoologico.classes
{
    public class ZoologicoClass
    {
        private List<Animal> animais = new List<Animal>();
        private List<TratadorAves> tratadoresAves = new List<TratadorAves>();
        private List<TratadorMamiferos> tratadoresMamiferos = new List<TratadorMamiferos>();

        public void AdicionarAnimal(Animal animal)
        {
            animais.Add(animal);
            Console.WriteLine($"{animal.Nome} foi adicionado");
        }


        public void AdicionarTratadorAves(TratadorAves tratador)
        {
            tratadoresAves.Add(tratador);
            Console.WriteLine($"{tratador.Nome} foi adicionado e sua especialidade é {tratador.Especialidade}");
        }

        public void AdicionarTratadorMamiferos(TratadorMamiferos tratador)
        {
            tratadoresMamiferos.Add(tratador);
            Console.WriteLine($"{tratador.Nome} foi adicionado e sua especialidade é {tratador.Especialidade}");
        }

        public void ListarAnimais()
        {
            if ( animais.Count > 0 )
            {
                Console.WriteLine("Animais no Zoológico: ");
                foreach (Animal animal in animais)
                {
                    animal.EmitirSom();
                    Console.WriteLine($"Nome: {animal.Nome}, Idade: {animal.Idade}");
                }
            }
            else
            {
                Console.WriteLine("A lista está vazia");
            }
        }

        public void ListarTratadoresMamifero()
        {
            if (tratadoresMamiferos.Count > 0)
            {
                Console.WriteLine("Tratadores de Mamíferos: ");
                foreach (TratadorMamiferos tratadores in tratadoresMamiferos)
                {
                    Console.WriteLine($"Nome: {tratadores.Nome}, Idade: {tratadores.Especialidade}");
                }
            }
            else
            {
                Console.WriteLine("A lista de tratadores de mamíferos está vazia");
            }

            if (tratadoresAves.Count > 0)
            {
                Console.WriteLine("Tratadores de Aves: ");
                foreach (TratadorAves tratadores in tratadoresAves)
                {
                    Console.WriteLine($"Nome: {tratadores.Nome}, Idade: {tratadores.Especialidade}");
                }
            }
            else
            {
                Console.WriteLine("A lista de tratadores de aves está vazia");
            }
        }

        public void AlimentarAnimais()
        {
            Console.WriteLine("Alimentando os animais...");
            foreach(Animal animal in animais)
            {
                if(animal is IAlimentavel alimentavel)
                {
                    alimentavel.Alimentar();
                }
            }
        }
    }
}

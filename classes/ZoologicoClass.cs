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

        public void AdicionarAnimal(Animal animal)
        {
            animais.Add(animal);
            Console.WriteLine($"{animal.Nome} foi adicionado");
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

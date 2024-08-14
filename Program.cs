using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.classes;

namespace Zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZoologicoClass zoologico = new ZoologicoClass();

            while (true)
            {
                Console.WriteLine("Selecione a opção: ");
                Console.WriteLine("1. Adicionar Mamífero");
                Console.WriteLine("2. Adicionar Ave");
                Console.WriteLine("3. Adicionar Reptil");
                Console.WriteLine("4. Listar Animais");
                Console.WriteLine("5. Alimentar animais");
                Console.WriteLine("6. Adicionar tratador de mamíferos");
                Console.WriteLine("7. Adicionar tratador de aves");
                Console.WriteLine("8. Listar tratadores");
                Console.WriteLine("9. Sair");

                string opcao = Console.ReadLine();

                if (opcao == "9")
                {
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do mamífero: ");
                        string nomeMamifero = Console.ReadLine();

                        Console.WriteLine("Digite a idade do mamífero: ");
                        int idadeMamifero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo de pelo do animal: ");
                        string tipoDePelo = Console.ReadLine();

                        Mamifero mamifero = new Mamifero(nomeMamifero, idadeMamifero, tipoDePelo);

                        zoologico.AdicionarAnimal(mamifero);
                        break;
                    case "2":
                        Console.WriteLine("Digite o nome da ave: ");
                        string nomeAve = Console.ReadLine();

                        Console.WriteLine("Digite a idade da ave: ");
                        int idadeAve= int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a envergadura do animal: ");
                        double envergadura= double.Parse(Console.ReadLine());

                        Ave ave = new Ave(nomeAve, idadeAve, envergadura);

                        zoologico.AdicionarAnimal(ave);
                        break;
                    case "3":
                        Console.WriteLine("Digite o nome da ave: ");
                        string nomeReptil = Console.ReadLine();

                        Console.WriteLine("Digite a idade da ave: ");
                        int idadeReptil = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a envergadura do animal: ");
                        string tipoEscama = Console.ReadLine();

                        Reptil reptil = new Reptil(nomeReptil, idadeReptil, tipoEscama);

                        zoologico.AdicionarAnimal(reptil);
                        break;
                    case "4":
                        zoologico.ListarAnimais();
                        break;
                    case "5":
                        zoologico.AlimentarAnimais();
                        break;
                    case "6":
                        zoologico.AdicionarTratadorMamiferos();
                        break;
                    case "7":
                        zoologico.AdicionarTratadorAves();
                        break;
                    case "8":
                        zoologico.
                    default:
                        Console.WriteLine("Opção desconhecida");
                        break;
                }
            }
        }
    }
}

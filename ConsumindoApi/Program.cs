

using ConsumindoApi;
using ConsumindoApi.Entities;
using ConsumindoApi.Entities.Services;
using System.Globalization;

namespace ConsumoApi
{

    class Program
    {
        public static void Main(string[] args)
        {
            Cotacoes cotacoes = new Cotacoes();
            Console.WriteLine("Para qual moeda você quer converter: Dollar ou Euro?");
            cotacoes.VerCotacao(Console.ReadLine());
            while (cotacoes.name == null)
            {
                Console.WriteLine("Escreva novamente");
                cotacoes.VerCotacao(Console.ReadLine());
                
            }

            Console.WriteLine("Qual o valor?");
            double numero= int.Parse(Console.ReadLine());
            double numeroMoeda = Convert.ToDouble(cotacoes.buy);
            numero = numero * numeroMoeda;
            
            Console.WriteLine("Valor convertido para " + cotacoes.name + " fica " +numero);
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desfio_Estacionamento_C_.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            
        }

        public void AdicionarVeiculo()
        {
             Console.Write("Digite a placa do veículo para estacionar: ");
             string inscricao = Console.ReadLine();
             veiculos.Add(inscricao);

             Console.WriteLine($"\n{inscricao} added successfully:");
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");            
            string placa = Console.ReadLine();
            veiculos.Remove(placa);
            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper() ))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int horas = Convert.ToInt16(Console.ReadLine());

                decimal valorTotal = 0;
                valorTotal = precoInicial * horas;

                Console.WriteLine($"O veícilo de placa {placa} foi removidoe o preço total doi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Deculpe, esse veículo não está estacionado aqui. confira se digitou a placa corretamente");
            }              
        
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: \n");
                foreach (string item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

        }



    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desfio_Estacionamento_C_.Models
{
    public class Estacionamento
    {
        private decimal parkingTax = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal parkingTax, decimal precoPorHora)
        {
            this.parkingTax = parkingTax;
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
            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper() ))
            {
                veiculos.Remove(placa);
                int horas;

                Console.Write("\nDigite a quantidade de horas que o veículo permaneceu estacionado: ");
                while (!int.TryParse(Console.ReadLine(), out horas) && horas >= 0)
                {
                    Console.WriteLine("Invalid Number !!");
                }

                decimal valorTotal = 0;
                valorTotal = precoPorHora * horas + parkingTax;

                Console.WriteLine($"O veículo de placa {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
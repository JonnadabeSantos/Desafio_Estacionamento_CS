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
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");            
            string placa = "";
            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper() ))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int horas = 0;
                decimal valorTotal = 0;

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
                Console.WriteLine("Os veículos estacionados são: ");
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

        }



    }

}
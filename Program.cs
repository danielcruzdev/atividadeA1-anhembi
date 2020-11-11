using System;
using System.Collections.Generic;
using System.Linq;

namespace AtividadeA1
{
    struct Veiculos
    {
        public string Marca;
        public string Modelo;
        public int AnoFabricacao;
        public string Placa;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculos> veiculos = new List<Veiculos>();
            int opcao = 0;

            do
            {
                Console.WriteLine("---- Cadastro de Veiculos ----");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Selecione a opção desejada:");
                Console.WriteLine("1 - Listar veículos cadastrados.");
                Console.WriteLine("2 - Inserir um novo veículo.");
                Console.WriteLine("3 - Listar os veículos filtrando por ano de fabricação.");
                Console.WriteLine("4 - Listar os veículos pelo ano de fabricação acima de um certo valor especificado.");
                Console.WriteLine("5 - Listar os veículos filtrando-se pelo modelo.");
                Console.WriteLine("0 - Sair do cadastro.");
                Console.WriteLine("----------------------------------------------");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Listagem de Veículos");
                        if (veiculos.Count == 0)
                        {
                            Console.WriteLine("Lista vazia! Faça um cadastro");
                            break;
                        }

                        foreach (var item in veiculos)
                        {
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine($"Marca: {item.Marca}");
                            Console.WriteLine($"Modelo: {item.Modelo}");
                            Console.WriteLine($"Ano de Fabricação: {item.AnoFabricacao}");
                            Console.WriteLine($"Placa: {item.Placa}");
                            Console.WriteLine("----------------------------------------------");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Inserir um veiculo");

                        Console.WriteLine("Digite a marca");
                        string marca = Console.ReadLine();

                        Console.WriteLine("Digite a placa");
                        string placa = Console.ReadLine();

                        Console.WriteLine("Digite o modelo");
                        string modelo = Console.ReadLine();

                        Console.WriteLine("Digite o ano de fabricação");
                        int anoFabricacao = int.Parse(Console.ReadLine());

                        var veiculo = new Veiculos
                        {
                            Marca = marca,
                            Placa = placa,
                            Modelo = modelo,
                            AnoFabricacao = anoFabricacao
                        };

                        var lastYear = 0;
                        var index = 0;

                        if (veiculos.Count == 0)
                            veiculos.Add(veiculo);
                        else
                        {
                            foreach (var item in veiculos)
                            {
                                if (item.AnoFabricacao < anoFabricacao)
                                {
                                    lastYear = item.AnoFabricacao;
                                    index++;
                                }
                            }

                            veiculos.Insert(index, veiculo);
                        }

                        break;

                    case 3:
                        if (veiculos.Count == 0)
                        {
                            Console.WriteLine("Lista vazia! Faça um cadastro");
                            break;
                        }

                        Console.WriteLine("Listar veículos filtrando por ano de fabricação");

                        Console.WriteLine("Digite o ano de fabricação desejado:");
                        var ano = int.Parse(Console.ReadLine());

                        foreach (var item in veiculos.Where(v => v.AnoFabricacao == ano))
                        {
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine($"Marca: {item.Marca}");
                            Console.WriteLine($"Modelo: {item.Modelo}");
                            Console.WriteLine($"Ano de Fabricação: {item.AnoFabricacao}");
                            Console.WriteLine($"Placa: {item.Placa}");
                            Console.WriteLine("----------------------------------------------");
                        }
                        break;

                    case 4:
                        if (veiculos.Count == 0)
                        {
                            Console.WriteLine("Lista vazia! Faça um cadastro");
                            break;
                        }

                        Console.WriteLine("Listar os veículos pelo ano de fabricação acima de um certo valor especificado pelo usuário");

                        Console.WriteLine("Digite o ano de fabricação desejado:");
                        var anoSelecionado = int.Parse(Console.ReadLine());

                        foreach (var item in veiculos.Where(v => v.AnoFabricacao >= anoSelecionado))
                        {
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine($"Marca: {item.Marca}");
                            Console.WriteLine($"Modelo: {item.Modelo}");
                            Console.WriteLine($"Ano de Fabricação: {item.AnoFabricacao}");
                            Console.WriteLine($"Placa: {item.Placa}");
                            Console.WriteLine("----------------------------------------------");
                        }
                
                        break;

                    case 5:
                        if (veiculos.Count == 0)
                        {
                            Console.WriteLine("Lista vazia! Faça um cadastro");
                            break;
                        }

                        Console.WriteLine("Listar os veículos filtrando pelo modelo");

                        Console.WriteLine("Digite o modelo desejado:");
                        var modeloSelecionado = Console.ReadLine();

                        foreach (var item in veiculos.Where(f => f.Modelo == modeloSelecionado))
                        {
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine($"Marca: {item.Marca}");
                            Console.WriteLine($"Modelo: {item.Modelo}");
                            Console.WriteLine($"Ano de Fabricação: {item.AnoFabricacao}");
                            Console.WriteLine($"Placa: {item.Placa}");
                            Console.WriteLine("----------------------------------------------");
                        }

                        break;

                    default:
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}

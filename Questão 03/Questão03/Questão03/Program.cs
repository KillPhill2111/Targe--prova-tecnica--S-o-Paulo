using Questão03.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Questão03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string jsonFileCaminho = "Faturamento.json"; // caminho do arquivo JSON


            // ler o conteúdo do arquivo JSON
            string conteudo = File.ReadAllText(jsonFileCaminho);

            // criamos uma lista dos faturamentos 
            List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(conteudo);


            if (faturamentos == null || faturamentos.Count == 0) //se o arquivo estuver vazio
                                                                 //ou não houver nenhuma faturamento registrado...
            {
                Console.WriteLine("Nenhum dado de faturamento encontrado.");
                return;
            }

            //aquie guardamos numa varivel generica os faturametos validos
            //que são maiores que 0, para podermos trabalhar de maneira mais organizada, 
            //obs: continua sendo uma lista
            var faturamentosValidos = faturamentos.Where(f => f.ValorFaturamento > 0).ToList();

            if (faturamentosValidos.Count == 0)
            {
                Console.WriteLine("Nenhum dia com faturamento registrado.");
                return;
            }

            // calcular o menor e  o maior valor de faturamento...
            double menorFaturamento = faturamentosValidos.Min(f => f.ValorFaturamento);
            double maiorFaturamento = faturamentosValidos.Max(f => f.ValorFaturamento);

            // fazer uma média mensal...
            double mediaMensal = faturamentosValidos.Average(f => f.ValorFaturamento);

            // fazer a media dos dias e ver quatos dia ficaram a cima da media...
            int diasAcimaDaMedia = faturamentosValidos.Count(f => f.ValorFaturamento > mediaMensal);

            //aqui os poderemso expor os dados encontrados
            Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
            Console.WriteLine($"Número de dias com faturamento superior à média mensal: {diasAcimaDaMedia}");


        }
    }
}

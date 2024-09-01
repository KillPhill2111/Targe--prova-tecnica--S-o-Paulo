using Questão04.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoTxt = @"C:\Users\filip\Documents\Filipe\Projetos de desenvolvimento e programação\Target- prova tecnica- São Paulo\Targe--prova-tecnica--S-o-Paulo\Questão 04\Questão04\Questão04\Entities\FaturamentoEstado.txt";

            var faturamentos=new List<Faturamento>();//guardamso a lista numa varivel var

            foreach (string linhaArq in File.ReadLines(caminhoTxt)) //buscamos o arquivo, neste exrcicio estamos usando um xt
            {
                Faturamento fat = Faturamento.TransformaParaStrings(linhaArq);
                faturamentos.Add(fat);
            }

            //fazer a soma dos faturamentos totais:
            double faturamentoTotal = 0;
            foreach (var fat in faturamentos)
            {
                faturamentoTotal += fat.ValorFaturamento;
            }
            Console.WriteLine("Porcentagem de contribuição do total por estado:");
            foreach (var fat in faturamentos)
            {
                double porcentagem = (fat.ValorFaturamento / faturamentoTotal) * 100;
                Console.WriteLine($"{fat.Estado}: {porcentagem:F2}%");
            }

        }
    }
}

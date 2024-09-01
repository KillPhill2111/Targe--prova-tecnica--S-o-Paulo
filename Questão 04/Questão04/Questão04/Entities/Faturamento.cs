using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Questão04.Entities;
using System.Globalization;

namespace Questão04.Entities
{
    class Faturamento
    {
        public string Estado { get; set; }
        public double ValorFaturamento { get; set; }


        public Faturamento(string estado, double valorFaturamento) //cosntrutor simples 
        {   
            Estado = estado;
            ValorFaturamento= valorFaturamento;
        }

        public static Faturamento TransformaParaStrings(string linha)
        {
          
            linha = linha.Trim(); // Remove espaços em branco no início e no final

            // Verificar se a linha contém o caractere '–'
            //if (!linha.Contains('–'))
            //{
            //    throw new ArgumentException("Formato de linha inválido: falta caractere separador.");
            //}

            var partes = linha.Split('–'); // Dividir a linha em estado e valor

            // Verificar se o número de partes está correto
            if (partes.Length != 2)
            {
                throw new ArgumentException("Formato de linha inválido: deve conter exatamente um caractere separador.");
            }

            string estado = partes[0].Trim(); // Guarda o estado
            double valor;

            // Tentar converter o valor e capturar possíveis erros
            if (!double.TryParse(partes[1].Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out valor))
            {
                throw new ArgumentException("Formato de valor inválido.");
            }

            return new Faturamento(estado, valor); // Cria um novo objeto Faturamento
        }
    }

    
}

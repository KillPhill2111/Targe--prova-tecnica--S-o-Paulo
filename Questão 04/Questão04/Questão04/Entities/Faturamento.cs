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
            if (string.IsNullOrWhiteSpace(linha))
            {
                throw new ArgumentException("A linha não pode estar vazia ou conter apenas espaços.");
            }
            var partes = linha.Split(':');
            if (partes.Length != 2)
            {
                throw new ArgumentException("Formato de linha inválido: deve conter exatamente um caractere separador ':'.");
            }
            string estado = partes[0].Trim();
            string valorString = partes[1].Trim();
            double valor=double.Parse(valorString);

            return new Faturamento(estado, valor);
        }
    }

    
}

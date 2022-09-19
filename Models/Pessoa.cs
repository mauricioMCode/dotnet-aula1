using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAula1.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Endereco { get; set;}

        public void Apresentar()
        {
           // Console.WriteLine($"Olá! meu nome é" + $"{Nome} tenho {Idade} anos e moro em {Endereco}.");
              Console.WriteLine($"Olá! meu nome é " + $"{Nome} tenho {Idade}\nanos e moro em {Endereco}.");
        }

    }
}


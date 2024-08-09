using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        
        public String Nome { get; set; } = string.Empty;
        public int Idade { get; set; }

        public void Apresentar() {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }

    }
}
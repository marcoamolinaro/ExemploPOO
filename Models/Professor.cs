using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Sou professor e meu salário é {Salario}");
        }
    }
}
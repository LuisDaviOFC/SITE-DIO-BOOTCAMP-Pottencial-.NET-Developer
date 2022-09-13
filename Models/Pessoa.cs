using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SITE_DIO_BOOTCAMP_Pottencial_.NET_Developer.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}
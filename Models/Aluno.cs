using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {

        }
        //O base(nome) informa que estamos passando o valor para a classe pai
        //Nesse exemplo a classe pae é a classe pessoa
        public Aluno(string nome) : base(nome)
        {
            //Método necessário pois classe pai exige o atributo nome no construtor
        }
        public double Nota { get; set; }

        //A palavra override informa que estou sobreescrevendo o método da classe pai
        //de onde foi herdado demais atributos e métodos
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}
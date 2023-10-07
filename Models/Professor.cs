using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    //sealed informa que classe é selada e não pode ser herdada
    public class Professor : Pessoa
    {
        public Professor()
        {

        }
        //O base(nome) informa que estamos passando o valor para a classe pai
        //Nesse exemplo a classe pae é a classe pessoa
        public Professor(string nome) : base(nome)
        {
            //Método necessário pois classe pai exige o atributo nome no construtor
        }
        public decimal Salario { get; set; }
        //A palavra override informa que estou sobreescrevendo o método da classe pai
        //de onde foi herdado demais atributos e métodos
        //sealed informa que metodo é selado e não pode ser sobreescrito pela classe filha
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e meu salário é {Salario}");
        }
    }
}
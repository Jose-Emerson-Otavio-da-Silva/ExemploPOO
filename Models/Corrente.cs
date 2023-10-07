using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        //A palavra override informa que estou sobreescrevendo o método da classe pai
        //de onde foi herdado demais atributos e métodos
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
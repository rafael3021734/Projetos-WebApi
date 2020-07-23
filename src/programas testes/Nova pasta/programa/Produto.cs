using System;
using programa;

namespace programa{

    class Produto{
        public string Nome {get; set;}
        public double Preco {get; set;}
        public int Qtd {get; set;}

        public double valorTotalEstoque (){
                return Preco * Qtd;

        }



    }
}
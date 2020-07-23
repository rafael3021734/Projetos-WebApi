using System;

namespace produto{

    class Produto{
        public string Nome;
        public double Preco;
        public int Qtd;

        public double valorTotalEstoque (){
                return Preco * Qtd;

        }



    }



}
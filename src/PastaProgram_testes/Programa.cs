using System;

namespace produto{

class Produto{
        public string Nome;
        public double Preco;
        public int Qtd;

        public double valorTotalEstoque (){
                return Preco * Qtd;

        }

    class Program{
        static void Main (string[] args) {
            
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.preço = double.Parse(Console.ReadLine(), cultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque");
            p.Qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto " + p);



        }

    }


}

}
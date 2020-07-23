using System;



namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Produto p = produto;
     
            Console.WriteLine("Hello World!");
            Console.Write("Nome: ");
            Console.WriteLine("Entre os dados do produto:");

            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque");
            p.Qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto " + valorTotalEstoque());

        }
    }
}

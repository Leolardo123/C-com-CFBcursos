using System;
class Aula6{
    static void Main(string[] args)
    {
        int n1, n2, n3;
        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";
        n1 = 10; n2 = 20; n3 = 30;

        //Console.Write(n1 + ", " + n2 + ", " + n3);//método manual

        //Console.Write("\nn1=\t{0}\nn2=\t{1}\nn3=\t{2}\n\n",n1,n2,n3);//método com formatação

        valorVenda = valorCompra + (valorCompra * lucro);
        Console.WriteLine("Produto........:{0,15}", produto);
        Console.WriteLine("Val.Compra.....:{0,15:c}", valorCompra);// :c -> converte em dinheiro
        Console.WriteLine("Lucro..........:{0,15:p}", lucro);// :p -> converte em porcentagem
        Console.WriteLine("Val.Venda......:{0,15:c}", valorVenda);//numero 15 indica que vai ser escrito da direita para esquerda, 15 espaços a frente

        //{0, 15:c}
        //{variavel,espaco:formatação}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaração e instanciamento do objeto
   
            Produto prod = new Produto();
            Cliente cli = new Cliente();
            Pedido ped = new Pedido();

            Console.Write("Digite o código do produto: ");
            prod.setCodigo(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite a descrição do produto: ");
            prod.setDescricao((Console.ReadLine()));
            Console.Write("Digite a categoria do produto: ");
            prod.setCategoria((Console.ReadLine()));
            Console.Write("Digite o valor do produto: ");
            prod.setValor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Código = " + prod.getCodigo() + "\nDescrição: " + prod.getDescricao() + "\nCategoria = " + prod.getCategoria() + "\nValor = " + prod.getValor().ToString("C"));
            

            Console.Write("Digite o nome do cliente:");
            cli.setNome(Console.ReadLine());
            Console.Write("Digite o cpf do cliente:");
            cli.setCpf(Console.ReadLine());
            Console.Write("Digite o endereço do cliente:");
            cli.setendereco(Console.ReadLine());
            Console.Write("Digite a idade do cliente:");
            cli.setidade(int.Parse(Console.ReadLine()));

            Console.WriteLine("Nome = " + cli.getNome() + "\nEndereço = " + cli.getendereco() + "\nCPF = " + cli.getCpf() + "\nidade = " + cli.getidade());
            

            Console.Write("Digite o numero do pedido:");
            ped.setnumero(int.Parse(Console.ReadLine()));
            Console.Write("Digite a quantidade do pedido:");
            ped.setquantidade(int.Parse(Console.ReadLine()));
            ped.settotal(prod.getValor() * ped.getquantidade());

            Console.WriteLine("Pedido = " + ped.getnumero() + "\nQuantidade = " + ped.getquantidade() + "\ntotal = " + ped.gettotal());
            Console.ReadKey();








































        }
    }
}

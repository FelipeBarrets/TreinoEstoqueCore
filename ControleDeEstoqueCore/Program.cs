using System;

namespace ControleDeEstoqueCore
{
 
        public class Program
        {
            public static void Main()
            {
                Console.WriteLine("Nome produto: ");
                string nomeproduto;
                nomeproduto = Console.ReadLine();
                Console.WriteLine("Preço produto: ");
                double preçoproduto;
                preçoproduto = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantia em estoque: ");
                int unidades;
                unidades = int.Parse(Console.ReadLine());



                estoqueatual(nomeproduto, preçoproduto, unidades);


            }
            static void estoqueatual(string nomeproduto, double preçoproduto, int unidades)
            {
                double preçototal = preçoproduto * unidades;
                Console.WriteLine("Dados do produto: " + nomeproduto + ", $ " + preçoproduto.ToString("F2") + ", " + unidades + " unidades, Total: $ " + preçototal.ToString("F2"));
                Console.WriteLine("Unidades a adicionar: ");
                int adicionar;
                adicionar = int.Parse(Console.ReadLine());
                unidades = unidades + adicionar;
                entradaprodutos(nomeproduto, preçoproduto, unidades);
            }
            static void entradaprodutos(string nomeproduto, double preçoproduto, int unidades)
            {
                double preçototal = preçoproduto * unidades;
                int saida;
                Console.WriteLine("Dados do produto: " + nomeproduto + ", $ " + preçoproduto.ToString("F2") + ", " + unidades + " unidades, Total: $ " + preçototal.ToString("F2"));
                Console.WriteLine("Unidades a retirar: ");
                saida = int.Parse(Console.ReadLine());
                unidades = unidades - saida;

                saidaprodutos(nomeproduto, preçoproduto, unidades);

            }
            static void saidaprodutos(string nomeproduto, double preçoproduto, int unidades)
            {
                double preçototal = preçoproduto * unidades;

                Console.WriteLine("Dados do produto: " + nomeproduto + ", $ " + preçoproduto.ToString("F2") + ", " + unidades + " unidades, Total: $ " + preçototal.ToString("F2"));

            }
        }

    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aposentadoria";

            // ========================================Variáveis========================================
            bool i = false;
            int anoAtual;
            string nascimento;
            string ingressao;
            int anoNasc = 0;
            int anoIngressado = 0;
            int anosTrabalhados;

            // ===============================Informações para o usuário================================
            Console.WriteLine("Requisitos para aposentadoria:");
            Console.WriteLine("-> 65 anos de idade no mínimo");
            Console.WriteLine("-> 30 anos trabalhados no mínimo");
            Console.WriteLine("-> No mínimo: 60 anos de idade e 25 anos trabalhados");
            Console.WriteLine("");

            anoAtual = DateTime.Now.Year;

            // =======================Validação da entrada do ano de nascimento=========================
            while (i == false)
            {
                Console.Write("Informe seu ano de nascimento: ");
                nascimento = Console.ReadLine();

                if (nascimento.Length > 4 || nascimento.Length < 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Digite o ano corretamente!");
                }

                else
                {
                    anoNasc = int.Parse(nascimento);

                    if (anoNasc >= anoAtual)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Digite o ano corretamente!");
                    }

                    else
                    {
                        i = true;
                    }
                }
            }

            i = false;

            // ==================Validação da entrada do ano de ingresso na empresa=====================
            while (i == false)
            { 
                Console.Write("informe o ano de ingresso na empresa: ");
                ingressao = Console.ReadLine();

                if (ingressao == "0")
                {
                    anoIngressado = int.Parse(ingressao);
                    i = true;
                }

                else if (ingressao.Length > 4 || ingressao.Length < 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Digite o ano corretamente!");
                }

                else
                {
                    anoIngressado = int.Parse(ingressao);

                    if (anoIngressado > anoAtual || anoIngressado <= anoNasc)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Digite o ano corretamente!");
                    }

                    else
                    {
                        i = true;
                    }
                }
            }

            int idade = anoAtual - anoNasc;

            if (anoIngressado == 0)
            {
                anosTrabalhados = 0;
            }

            else
            {
                anosTrabalhados = anoAtual - anoIngressado;
            }

            Console.WriteLine("");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Anos trabalhados: {anosTrabalhados}");

            // =========Validação da aposentadoria (se o usuário pode ou não se aposentar)==============
            if (idade >= 65 || anosTrabalhados >= 30 || idade >= 60 && anosTrabalhados >= 25)
            {
                Console.WriteLine("");
                Console.WriteLine("Requerer aposentadoria");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Não requerer");
            }

            Console.ReadKey();
        }
    }
}

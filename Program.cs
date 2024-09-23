using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string op;
            bool continuar = true;
            string resposta;
           
            int n;
            
            
            Paciente p1 = new Paciente();
            while (continuar)
            {
                Console.WriteLine("--Sistema Hospital--\n\n");
                Console.WriteLine("O que Deseja Fazer?\n\n1-Cadastrar Paciente\n2-Listar Pacientes\nQ-Sair do Software");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        p1.Cadastro();
                        break;

                    case "2":

                        p1.ListarPaciente();
                        break;

                    case "Q":
                        Console.WriteLine("Saindo do Software em:");
                        for (n = 3; n >= 0; n--)
                        {
                            Thread.Sleep(1200);
                            Console.WriteLine(n);
                        }
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Deseja Continuar?\nS/N");
                resposta = Console.ReadLine();
                if (resposta == "N")
                {
                    continuar = false;
                    Console.WriteLine("Saindo do Sistema!!");
                    for (n = 3; n >= 0; n--)
                    {
                        Thread.Sleep(700);
                        Console.WriteLine(n);
                    }
                    Environment.Exit(0);
                }
                    Console.WriteLine("/-----------------------------/");
                Console.WriteLine("Voltando ao Sistema!!\n\nAguarde um Momento");
                for (n = 3; n >= 0; n--)
                {
                    Thread.Sleep(650);
                    Console.WriteLine(n);
                }
                    Console.WriteLine("*------------------------------*");
                    
                
            }
            
           
            Console.ReadKey();
        }
    }
}

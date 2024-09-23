using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Paciente
    {
        int p;
        public string[] nome = new string[10];
        public string[] data_nasc = new string[10];
        public int[] idade = new int[10];
        public string telefone;
        public string[] cpf = new string[10];
        public string[] tipo_sanguineo= new string[10];

        public void Cadastro()
        {
            Console.WriteLine("Quantos pacientes deseja cadastrar:");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do Paciente:");
            Console.WriteLine("Informe o CPF do Paciente:");
            Console.WriteLine("Informe o tipo Sanguíneo:");
            for (int i = 0; i < p; i++)
            {
                nome[i] = Console.ReadLine();
                cpf[i] = Console.ReadLine();
                tipo_sanguineo[i]= Console.ReadLine();
            }

        }
        public void ListarPaciente()
        {
            for (int i = 0; i < 10; i++)
            {
                if (nome[i] != null || cpf[i] != null)
                {
                    Console.WriteLine("\n"+nome[i]);
                    Console.WriteLine(cpf[i]);
                    Console.WriteLine(tipo_sanguineo[i]+"\n\n");
                }
            }
               
                
                
            
        }
       
                
                   
                
           
            
        }
    }


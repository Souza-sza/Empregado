
using Course;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace SegundoProjeto
{
    class program
    {
        static void Main(String[] args)
        {
            List<Empregado> lista = new List<Empregado>();
            Console.Write("quantos funcionarios deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employees #"+ (i + 1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Empregado(id, nome, salario));
                Console.WriteLine();
                Console.WriteLine("-------------------");

            }
           

            Console.Write("Entre com o Id do funcionario que vai quanhar o aumento: ");
            double Idchecagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             
            Empregado emp = lista.Find(x=> x.Id == Idchecagem);
            if (emp != null)
            {
                Console.Write("Digite a porcentagem do aumento: %");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.Aumento(porcentagem);
            }
            else
            {
                Console.WriteLine("esse Id não existe!!!");
            }

            Console.WriteLine("------------");
            Console.WriteLine("dados empregado");

            foreach (Empregado obj in lista)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
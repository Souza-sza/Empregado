using System.Globalization;
using System.Net.NetworkInformation;

using System;
namespace Course
{
    class Empregado
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public double Salario { get; private set; }
       
        public Empregado(string nome,int id, double salario)
        {
            Name = nome;
            Id = id;
            Salario = salario;
        }

        public double Aumento(double percentual)
        {
            return Salario += Salario * percentual / 100;
        }

        public Empregado(int id, string name, double salario) 
        {
            Id = id;
            Name = name;
            Salario = salario;
        }
        public override string ToString()
        {
            return "Id " + Id + ", " + "Name " + Name + ", Salario: R$" + Salario.ToString("F2", CultureInfo
                .InvariantCulture);
        }
    }
}
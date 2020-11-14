using System;

namespace exe._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do seu salário");
            double salario = double.Parse(Console.ReadLine());
            if(salario<500){
                double reajuste = salario+(salario*0.30);
                Console.WriteLine("O salário reajustado é de "+reajuste+" reais");
            }else{
                Console.WriteLine("Você não tem direito a aumento");
            }
        }
    }
}

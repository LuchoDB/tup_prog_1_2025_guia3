using System;
namespace Principal
{
    class Loteria
    {
        public static void Main(string[] args)
        {
            int num, cant_par, cant_impar, acum_impar, may, men;
            double prom;

            cant_par = 0;
            cant_impar = 0;
            acum_impar = 0;
            may = 0;
            men = 0;
            prom = 0;

            for (int i = 1 ;i <= 20 ;i++) 
            {

                Console.WriteLine($"Ingrese el {i}° número.");
                num = int.Parse(Console.ReadLine());

               if ( i == 1)
                {
                    may = num;
                    men = num;
                }

                if (num%2 == 0)
                {
                    cant_par++;
                } else
                {
                    cant_impar++;
                    acum_impar += num;
                }

                if (num > may)
                {
                    may = num;
                } else if (num < men) 
                {
                    men = num;
                }

                
            }

            if (cant_impar != 0)
            {
                prom = acum_impar / cant_impar;
            }

            Console.WriteLine($"El promedio de los impares es: {prom}");
            Console.WriteLine($"El mayor numero es: {may}");
            Console.WriteLine($"El menor numero es: {men}");
            Console.WriteLine($"Hay {cant_par} numeros pares");
        }
    }
}
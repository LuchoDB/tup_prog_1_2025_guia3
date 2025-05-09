using System;
namespace Principal
{
    class DJ { 
    public static void Main(string[] args)
    {
            int n, min, seg, mins, segs, horas, totalSeg, duracion, maxDuracion, minDuracion;
            string nombre, nombreMax = "", nombreMin = "";
            int maxMin, maxSeg, minMin, minSeg;

            totalSeg = 0;
            maxDuracion = -1;
            minDuracion = 999999;

            Console.WriteLine("¿Cuantas canciones quiere agregar?");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Ingrese el nombre de la cancion");
                nombre = Console.ReadLine()!; /*El simbolo ! es para asegurar al compilador que este input no sera vacio*/
                Console.WriteLine("¿Cuantos minutos dura?");
                min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("¿Cuantos segundos tiene?");
                seg = Convert.ToInt32(Console.ReadLine());

                duracion = (min * 60) + seg;
                totalSeg += duracion;

                if (duracion > maxDuracion)
                {
                    maxDuracion = duracion;
                    nombreMax = nombre;
                }

                if (duracion < minDuracion)
                {
                    minDuracion = duracion;
                    nombreMin = nombre;
                }
            }

            horas = totalSeg / 3600;
            mins = (totalSeg % 3600) / 60;
            segs = totalSeg % 60;

            maxMin = maxDuracion / 60;
            maxSeg = maxDuracion % 60;
            minMin = minDuracion / 60;
            minSeg = minDuracion % 60;

            Console.WriteLine($"Duracion total de la lista: {horas:D2}:{mins:D2}:{segs:D2}");
            Console.WriteLine($"La cancion mas larga es: {nombreMax} que dura {maxMin:D2}:{maxSeg:D2}");
            Console.WriteLine($"La cancion mas corta es: {nombreMin} que dura {minMin:D2}:{minSeg:D2}");
    }
   }
}
using System;
namespace Principal
{
    class DJ2
    {
        public static void Main(string[] args)
        {
            int n, min, seg, mins, segs, horas, totalSeg, duracion, maxDuracion, minDuracion;
            string nombre, nombreMax = "", nombreMin = "";
            int maxMin, maxSeg, minMin, minSeg;
            bool cortar = false;

            totalSeg = 0;
            maxDuracion = -1; 
            minDuracion = 999999;

            Console.WriteLine("Ingresar carga de canciones (maximo 74 minutos)");

            do
            {
                Console.WriteLine("Ingrese el nombre de la cancion");
                nombre = Console.ReadLine();
                
                Console.WriteLine("¿Cuantos minutos dura?");
                min = int.Parse(Console.ReadLine());
               
                Console.WriteLine("¿Cuantos segundos tiene?");
                seg = int.Parse(Console.ReadLine());

                duracion = (min * 60) + seg;

                if ((totalSeg + duracion > 4440))
                {
                    Console.WriteLine("No se puede agregar esta cancion, supera el limite de 74 minutos (4440 segundos)");
                    cortar = true;
                }
                else
                {
                    totalSeg += duracion;
                }
               
                

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

            } while (cortar = true || totalSeg>=4440);
        }
    }
}
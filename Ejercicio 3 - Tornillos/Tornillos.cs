using System;
namespace Principal
{
    class Tornillos
    {
        public static void Main(string[] args)
        {
            /*Variables Locales*/
            int codigoLote, cant_Fallas;
            double porcentajeFallas;
            double med_Esperada, med_Actual, errAbs, mayError;
            /*Variables globales*/
            int tot_Lotes, tot_Fallas;
            int loteMenorFalla, loteMayorFalla;
            int menorCantFalla, mayorCantFalla;

            tot_Lotes = 0;
            tot_Fallas = 0;
            menorCantFalla = 11; // Inicializa a un valor mayor que 10 para asegurar que cualquier lote tenga menos fallas
            mayorCantFalla = -1;// Inicializa a un valor menor que 0 para asegurar que cualquier lote tenga más fallas
            loteMayorFalla = 0;
            loteMenorFalla = 0;

            Console.WriteLine("Ingrese el codigo de lote o ingrese 0 para salir");
            codigoLote = int.Parse(Console.ReadLine());

            do
            {
                tot_Lotes++;
                cant_Fallas = 0;
                mayError = 0;

                Console.WriteLine("Ingrese la medida esperada");
                med_Esperada = double.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++) // Recorre los 10 tornillos a medir
                {
                    Console.WriteLine($"Ingrese la medida del {i} ° elemento");
                    med_Actual = double.Parse(Console.ReadLine());

                    errAbs = Math.Abs(med_Actual - med_Esperada); // Calcula el error absoluto

                    if (errAbs > mayError)
                    {
                        mayError = errAbs; // Guarda el mayor error absoluto
                    }

                    if (errAbs > 0)
                    {
                        cant_Fallas++; // Incrementa la cantidad de fallas
                    }
                }

                porcentajeFallas = (cant_Fallas * 100.0) / 10; // Calcula el porcentaje de fallas
                tot_Fallas += cant_Fallas; // Acumula la cantidad de fallas totales

                if (cant_Fallas < menorCantFalla) //Guarda el lote con menor cantidad de fallas
                {
                    menorCantFalla = cant_Fallas;
                    loteMenorFalla = codigoLote;
                }

                if (cant_Fallas > mayorCantFalla) //Guarda el lote con mayor cantidad de fallas
                {
                    mayorCantFalla = cant_Fallas;
                    loteMayorFalla = codigoLote;
                }

                Console.WriteLine($"Resultados del lote: {codigoLote}");
                Console.WriteLine($"Mayor Error Absoluto: {mayError.ToString("F2")}");
                Console.WriteLine($"Porcentaje de Fallas: {porcentajeFallas.ToString("F2")}%");
                Console.WriteLine();
                Console.WriteLine("Ingrese el codigo del siguiente lote o ingrese 0 para salir");
                codigoLote = int.Parse(Console.ReadLine());


            } while (codigoLote != 0);

            if (tot_Lotes > 0)
            {
                double porcentajeTotal = (tot_Fallas * 100) / (tot_Lotes * 10);
                Console.WriteLine("Reporte Final:");
                Console.WriteLine($"Cantidad de lotes procesados: {tot_Lotes}");
                Console.WriteLine($"Porcentaje total de fallas: {porcentajeTotal.ToString("F2")}%");
                Console.WriteLine($"Lote con menor cantidad de fallas: {loteMenorFalla}");
                Console.WriteLine($"Lote con mayor cantidad de fallas: {loteMayorFalla}");
            }
        }
    }
}
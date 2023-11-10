using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Examen_OAEA2
{
    internal class CurpNombre
    {
        public static char ObtenerSexo(string curp)
        {
            return curp[10] == 'H' ? 'M' : 'F';


        }

        public static DateOnly ObtenerFechaNacimiento(string curp)
         {

             string anio = curp.Substring(4,2);
             string mes = $"{curp[6]}{curp[7]}";
             string dia = $"{curp[8]}{curp[9]}";


             string fechaNacimiento = $"{dia}/{mes}/{anio}";

             return DateOnly.ParseExact(fechaNacimiento, "dd/MM/yy", CultureInfo.InvariantCulture );

         }



        public void Calificaciones()
        {
            int[] arreglo = new int[10];
            Random alea = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                int calificacion = alea.Next(1, 100);
                arreglo[i] = calificacion;
            }
            Console.WriteLine("CALIFICACIONES DESORDENADAS");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
            int tem;
            for (int i = 1; i < arreglo.Length; i++)
            {
                for (int j = arreglo.Length - 1; j >= i; j--)
                {
                    if (arreglo[j - 1] < arreglo[j])
                    {
                        tem = arreglo[j - 1];
                        arreglo[j - 1] = arreglo[j];
                        arreglo[j] = tem;
                    }
                }
            }
            Console.WriteLine("CALIFICACIONES ORDENADAS");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
            int numero = 75;
            int inicio = 0;
            int fin = arreglo.Length - 1;
            bool encontrar = false;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                if (arreglo[medio] == numero)
                {
                    Console.WriteLine($"El numero {numero} esta en la posicion {medio}");
                    encontrar = true;
                    break;
                }
                else if (arreglo[medio] < numero)
                {
                    fin = medio - 1;
                    medio = (inicio + fin) / 2;

                }
                else
                {
                    inicio = medio + 1;
                    medio = (inicio + fin) / 2;
                }

            }
            if (!encontrar)
            {
                Console.WriteLine($"Lo siento el {numero} no se encuentra en la lista");
            }

        }
    }
}

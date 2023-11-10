using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_OAEA2
{

     public class ventaPorVendedor
    {

        private int[,] tablaVentas;

        public ventaPorVendedor(int[,] ventas)
        {
            tablaVentas = ventas;
        }

        public void ImprimirTabla()
        {
            for (int vendedor = 0; vendedor < tablaVentas.GetLength(0); vendedor++)
            {
                Console.Write($"Vendedor {vendedor + 1}: ");
                for (int producto = 0; producto < tablaVentas.GetLength(1); producto++)
                {
                    Console.Write($"{tablaVentas[vendedor, producto]} ");
                }
                Console.WriteLine();
            }
        }

        public void CalcularGananciaPorVendedor()
        {
            for (int vendedor = 0; vendedor < tablaVentas.GetLength(0); vendedor++)
            {
                int gananciaVendedor = 0;
                for (int producto = 0; producto < tablaVentas.GetLength(1); producto++)
                {
                    gananciaVendedor += tablaVentas[vendedor, producto];
                }
                Console.WriteLine($"El vendedor {vendedor + 1} tuvo una ganancia de {gananciaVendedor} pesos.");
            }
        }

        public void CalcularGananciaPorProducto()
        {
            for (int producto = 0; producto < tablaVentas.GetLength(1); producto++)
            {
                int gananciaProducto = 0;
                for (int vendedor = 0; vendedor < tablaVentas.GetLength(0); vendedor++)
                {
                    gananciaProducto += tablaVentas[vendedor, producto];
                }
                Console.WriteLine($"El producto {producto + 1} generó {gananciaProducto} pesos de ganancia.");
            }
        }
    }



}

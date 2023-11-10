namespace Examen_OAEA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  Console.Write("Ingresa tu Curp: ");
            string curp = Console.ReadLine();


            char sexo = CurpNombre.ObtenerSexo(curp);
           DateOnly fechaNacimiento = CurpNombre.ObtenerFechaNacimiento(curp);


           Console.WriteLine($"Tu Genero es el Siguente {sexo} Y Tu Fecha de Naciminto es la Siguente {fechaNacimiento : dd/MM/yy}");
          */


            //CurpNombre curpNombre = new CurpNombre();
            //curpNombre.Calificaciones();


            int[,] TablaVentas =
                {{500,3000,100,400 },
                {1000,150,200,500 },
                {2500,1800,2900,300},
                {400,130,90,2400 },
                {60,20,4000,3600 }
                
            };



            ventaPorVendedor ventaPorVendedor = new ventaPorVendedor(TablaVentas);


            Console.WriteLine("Tabla de ventas:");
            ventaPorVendedor.ImprimirTabla();

            Console.WriteLine("\nGanancia total por vendedor:");
            ventaPorVendedor.CalcularGananciaPorVendedor();

            Console.WriteLine("\nGanancia total por producto:");
            ventaPorVendedor.CalcularGananciaPorProducto();
        }
    }
}
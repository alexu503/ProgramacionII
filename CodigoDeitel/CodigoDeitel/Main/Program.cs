using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoDeitel.Logic;

namespace CodigoDeitel.Main {
    class Program {
        static void Main(string[] args) {
            // crea instancia de un objeto EmpleadoBaseMasComision
            EmpleadoBaseMasComision4 empleado = new EmpleadoBaseMasComision4("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);
            // muestra en pantalla los datos del empleado por comisión con salario base
            Console.WriteLine("Información del empleado obtenida por las propiedades y los métodos: \n" ); 
            Console.WriteLine("{0} {1}", "El primer nombre es", empleado.PrimerNombre);
            Console.WriteLine("{0} {1}", "El apellido paterno es", empleado.ApellidoPaterno);
            Console.WriteLine("{0} {1}", "El número de seguro social es", empleado.NumeroSeguroSocial);
            Console.WriteLine("{0} {1:C}", "Las ventas son: ", empleado.VentasBrutas);
            Console.WriteLine("{0} {1:F2}", "La tarifa de comisión es", empleado.TarifaComision);
            Console.WriteLine("{0} {1:C}", "Los ingresos son", empleado.Ingresos());
            Console.WriteLine("{0} {1:C}", "El salario base es", empleado.SalarioBase);
            empleado.SalarioBase = 1000.00M; // establece el salario base
            Console.WriteLine( "\n{0}:\n\n{1}", 
                "Información actualizada del empleado, obtenida mediante ToString", empleado ); 
            Console.WriteLine("ingresos: {0:C}", empleado.Ingresos());
            Console.ReadKey();
        }
    }
}

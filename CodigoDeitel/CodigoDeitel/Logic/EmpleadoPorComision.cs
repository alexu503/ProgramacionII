using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoDeitel.Logic {
    public class EmpleadoPorComision: object {
        public string primerNombre;
        public string apellidoPaterno; 
        public string numeroSeguroSocial;
        public decimal ventasBrutas; // ventas semanales totales
        public decimal tarifaComision; // porcentaje de comisión

        // constructor con cinco parámetros
        public EmpleadoPorComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa) {
            // la llamada implícita al constructor del objeto ocurre aquí
            primerNombre = nombre;
            apellidoPaterno = apellido; numeroSeguroSocial = nss;
            ventasBrutas = ventas; // valida las ventas brutas mediante una propiedad 
            tarifaComision = tarifa; // valida la tarifa de comisión mediante una propiedad
        } // fin del constructor de EmpleadoPorComision con cinco parámetros

        // propiedad de sólo lectura que obtiene el primer nombre del empleado por comisión
        public string PrimerNombre {
            get { return primerNombre; } // fin de get
        } // fin de la propiedad PrimerNombre
        // propiedad de sólo lectura que obtiene el apellido paterno del empleado por comisión
        public string ApellidoPaterno {
            get { return apellidoPaterno; } // fin de get
        } // fin de la propiedad ApellidoPaterno // propiedad de sólo lectura que obtiene el
          // número de seguro social del empleado por comisión
        public string NumeroSeguroSocial {
            get { return numeroSeguroSocial; } // fin de get
        } // fin de la propiedad NumeroSeguroSocial
          // propiedad que obtiene y establece las ventas brutas del empleado por comisión
        public decimal VentasBrutas {
            get { return ventasBrutas; } // fin de get
            set { ventasBrutas = (value < 0) ? 0 : value; } // fin de set
        } // fin de la propiedad VentasBrutas
        // propiedad que obtiene y establece la tarifa de comisión del empleado por comisión
        public decimal TarifaComision {
            get { return tarifaComision; } // fin de get
            set { tarifaComision = (value > 0 && value < 1) ? value : 0; } // fin de set
        } // fin de la propiedad TarifaComision

        //Calculo del salario del empleado por comisión
        public virtual decimal Ingresos() { 
            return tarifaComision * ventasBrutas;
        } // fin del método Ingresos

        // devuelve representación string del objeto EmpleadoPorComision
        public override string ToString() {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}", 
                "empleado por comisión", PrimerNombre, ApellidoPaterno, 
                "número de seguro social", NumeroSeguroSocial,
            "ventas brutas", VentasBrutas, "tarifa de comisión", TarifaComision);
        } // fin del método ToString
    } // fin de la clase EmpleadoPorComision
}

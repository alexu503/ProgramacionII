using System;

namespace Relaciones {

    class Program {

        class Sucursal {
            public int id;
            public string name;
        }

        class Postulacion {
            public int id;
            public void Enviar() {}
        }

        class Domicilio {
            public int num;
            public string depa;

            public string calle {
                get { return calle; }
                set { calle = value; }
            }
        }

        class Categoria {

            public int id {
                get { return id; }
                set { id = value; }
            }

            public string nombrecat {
                get { return nombrecat; }
                set { nombrecat = value; }
            }
        }

        class VisitaPersonaSucursal {
            public Sucursal establecimiento;//relacion de asociacion
            public Persona postulante;//relacion de asociacion
            public DateTime fecha;

        }

        class Persona {
            // composicion con la clase domicilio
            Domicilio dom;
            Categoria cat;

            //Ya se reciben los datos sin crear instancia dentro de la clase
            public Persona(Categoria c) {

                dom = new Domicilio();// se crea la instancia
                dom.calle = "San Miguel";
            }

            //Ya se reciben los datos sin crear instancia dentro de la clase
            public Persona() {
                // se crea la instancia
                dom = new Domicilio();
                dom.calle = "San Miguel";
            }

            public void AplicarPlaza() {
                //dependencia:
                Postulacion postulacion = new Postulacion();
                postulacion.Enviar();
            }
        }

        static void Main(string[] args) {
            Categoria categoria = new Categoria();
            categoria.nombrecat = "bodega";

            // Agregacion
            Persona per = new Persona();
            Persona per2 = new Persona(categoria);
            Sucursal sucursal = new Sucursal();

            VisitaPersonaSucursal vp = new VisitaPersonaSucursal();
            vp.establecimiento = sucursal;
            vp.postulante = per;
        }
    }
}

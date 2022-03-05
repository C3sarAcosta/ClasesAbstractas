using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    /*
     Como vemos a diferencia de las interfaces en las clases abstractas podemos 
    incluir modificadores de acceso.

     Y como hacíamos en las interfaces, en la clase que va a implementar la clase, 
    indicamos dos puntos y la clase.

     A diferencia de las interfaces, en las clases que implementan 
    una clase abstracta debemos sobrescribir cada uno de los métodos
     */
    internal class Cuadrado : Pieza
    {
        public decimal lado { get; set; }
        public Cuadrado(decimal lado)
        {
            this.lado = lado;   
        }
        public override decimal Area()
        {
            return lado * lado;
        }

        protected override decimal Perimetro()
        {
            return lado * 4;
        }
    }
}

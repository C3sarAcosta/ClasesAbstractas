using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    /*
     El modificador abstract
         Utilizamos el modificador abstract para definir clases o miembros de clases 
         (métodos, propiedades, events, o indexers) para indicar que esos miembros deben 
         ser implementados en las clases que derivan de ellas.

    Cuando declaramos una clase como abstract estamos indicado que esa clase va a ser 
     utilizada como clase base de otras clases, ya que ella misma no se puede instanciar.

     Una clase abstracta puede contener miembros abstractos como no abstractos, 
     y todos los miembros deben ser implementados en la clase que la implementa.
     */
    internal abstract class Pieza
    {
        public abstract decimal Area();
        protected abstract decimal Perimetro();

        public bool EjemploMetodo()
        {
            return false;
        }

        public int ladosDiferentes = 1;
        
    }
}

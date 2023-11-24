using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasPractica
{
    public class Nodo
    {
        public Animal animal { get; set; }
        public Nodo _siguiente { get; set; }

        public Nodo(Animal _animal)
        {
            animal = _animal;
            _siguiente = null;
        }

        public Nodo(Animal _animal, Nodo siguiente)
        {
            animal=_animal;
            _siguiente = siguiente;
        }

        public Animal _animal { get { return animal; } set { animal = value; } }
        public Nodo siguiente { get { return _siguiente; } set { _siguiente=value; } }

    }



}

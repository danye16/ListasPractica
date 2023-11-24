using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ListasPractica
{
    public class ListaSimple
    {
        private Nodo primero;
        private Nodo ultimo;

        public ListaSimple()
        {

            primero = ultimo = null;
        }

        public void InsetarPrincipio(Animal animal)
        {
            if (ListaVacia())
            {
                primero = ultimo = new Nodo(animal);
                Console.WriteLine("Elemento agregado con exito");
            }
            else
            {
                primero = new Nodo(animal, primero);
                Console.WriteLine("Elemento agregado con exito");

            }
        }
        public void InsertarFinal(Animal animal)
        {
            if (ListaVacia())
            {
                primero=ultimo=new Nodo(animal);
                Console.WriteLine("Elemento agregado con exito");


            }
            else
            {
               ultimo=ultimo.siguiente =new Nodo(animal);
                //Nodo anterior = null;
                //Nodo actual = primero;
                //while (actual != null)
                //{
                //    actual.siguiente = new Nodo(animal);
                //    new Nodo(animal).siguiente = actual;
                //    anterior = actual;

                //    actual=actual.siguiente;
                //}
              
            }
        }
        public void InsertarMedio(Animal animal)
        {
            //  int longitud = LongitusLista();
            //  int medio = 0;

            //  medio = longitud/2;
            //  Nodo actual = primero;
            //  Nodo anterior = null;
            //  while ( actual!=null) 
            //  {
            //      if (actual.animal.id==medio) 
            //      {
            //          actual = actual.siguiente;
            //      }


            //  }
            //  anterior = actual;
            //  Nodo nuevoAnimal = new Nodo(animal, actual.siguiente);
            //  anterior.siguiente = nuevoAnimal;
            //}
            int longitud = LongitusLista();
            int medio = 0;
            medio = longitud / 2;
            int contador = 0;
            Nodo actual = primero;
            Nodo anterior = null;
            while (actual != null)
            {
                if (contador == medio)
                {
                    actual.siguiente = new Nodo(animal);
                    new Nodo(animal).siguiente = actual;

                }
                anterior = actual;
                actual = actual.siguiente;
                contador++;

            }

        }
        public bool ListaVacia()
        {
            if (primero != null)
            {
                return false;
            }
            else { return true; }

        }
        public int LongitusLista()
        {
            int contador = 0;
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacia");
                return 0;
            }
            if (primero != null && primero.siguiente == null)
            { return 1; }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {


                    actual = actual.siguiente;
                    contador++;

                }
                return contador + 1;
            }

        }
        public void imprimir()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista ta vacia jovensito");
            }
            else
            {
                Nodo actual = primero;

                while (actual != null)
                {
                    Console.WriteLine(actual.animal.id);
                    Console.WriteLine(actual.animal.raza);

                    actual = actual.siguiente;
                }
            }
        }

        public void Buscar(int palabra)
        {
            bool centinela = false;
            if (ListaVacia())
            { Console.WriteLine("La lista ta vacia"); }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    if (palabra == actual.animal.id)
                    {
                        Console.WriteLine("El elemento si existe en la lista");
                        centinela = true;
                        break;
                    }
                    else
                    {
                        actual = actual.siguiente;
                    }
                }

                if (!centinela)
                { Console.WriteLine("El elemento no existe en ninguna lista"); }
            }

        }
     
    }
}

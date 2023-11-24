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
        Nodo primero;
        Nodo ultimo;

        public ListaSimple()
        {

            primero = ultimo= null;
        }

        public void InsetarPrincipio(Animal animal)
        {
            if (ListaVacia())
            {
                primero = ultimo = new Nodo(animal);
            }
            else
            {
                primero= new Nodo(animal, primero);
            }
        }
        public void InsertarFinal(Animal animal)
        {
            if (!ListaVacia())
            {
                primero = ultimo = new Nodo(animal);

            }
            else
            {
                ultimo=ultimo.siguiente =new Nodo(animal);
            }
        }
        public bool ListaVacia()
        {
            if (primero != null)
                return false;
            else return true;
        }
        public int LongitusLista()
        {
            int contador = 0;
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacia");
                return 0;
            }
            if (primero !=null && primero.siguiente == null)
            {  return 1;}
            else 
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    Console.WriteLine(actual.animal.id);
                    Console.WriteLine(actual.animal.raza);

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

                while (actual!=null)
                {
                    Console.WriteLine(actual.animal.id);
                    Console.WriteLine(actual.animal.raza);

                    actual = actual.siguiente;
                }
            }
        }
        
        public void Buscar(int palabra)
        {
            bool centinela= false;
            if (ListaVacia())
            { Console.WriteLine("La lista ta vacia"); }
            else
            {
                Nodo actual = primero;
                while (actual!=null)
                {
                    if (palabra ==actual.animal.id )
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

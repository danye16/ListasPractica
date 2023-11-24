namespace ListasPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaSimple listaSimple=new ListaSimple();

            Console.WriteLine("Hola Presione una opcion");
            Console.WriteLine("2 para Agregar lista al principio");
            Console.WriteLine("3 para Agregar lista al final");
            Console.WriteLine("4 para Agregar lista al principio");
            Console.WriteLine("5 Imprimir Lista");
            Console.WriteLine("6 para Buscar un elemento");
            int opcion = Convert.ToInt32(Console.ReadLine());



            while (opcion != 1) 
            {
                switch (opcion)
                {
                    case 2:
                        Console.WriteLine("Ingrese los datos");
                        Animal animal = new Animal();

                        animal.raza = Console.ReadLine();
                        animal.id =Convert.ToInt32(Console.ReadLine()); 
                        listaSimple.InsetarPrincipio(animal);
                        break;
                    case 3:
                        Animal animal2 = new Animal();

                        Console.WriteLine("Ingrese Datos");
                        animal2.raza = Console.ReadLine();

                        animal2.id = Convert.ToInt32(Console.ReadLine());
                        listaSimple.InsertarFinal(animal2);
                        break; 
                    case 6:
                        Console.WriteLine("Ingrese el elemento a buscar en una lista");
                        int buscador= Convert.ToInt32(Console.ReadLine());
                        listaSimple.Buscar(buscador);
                        break;

                    case 5:
                        listaSimple.imprimir();
                        break;
                }
                Console.WriteLine("Hola Presione una opcion");
                 opcion = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
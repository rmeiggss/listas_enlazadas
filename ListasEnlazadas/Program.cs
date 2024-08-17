// See https://aka.ms/new-console-template for more information
using ListasEnlazadas;

//Console.WriteLine("Hello, World!");

ListaSimpleAppService serviceLista = new ListaSimpleAppService();
serviceLista.InsertarFIFO(10);
serviceLista.InsertarFIFO(20);
serviceLista.InsertarFIFO(30);
serviceLista.InsertarFIFO(40);
serviceLista.InsertarFIFO(50);

serviceLista.Eliminar(20);

serviceLista.Recorrido();

int datoBuscar;
//do
//{
//    Console.WriteLine("Ingrese el dato a buscar:");
//    datoBuscar = int.Parse(Console.ReadLine());
//    var busqueda = serviceLista.Buscar(datoBuscar);
//    Console.WriteLine(busqueda ? $"El dato {datoBuscar} existe" : $"El dato {datoBuscar} no existe");
//} while (datoBuscar != 0);

do
{
    Console.WriteLine("Ingrese el dato a eliminar:");
    datoBuscar = int.Parse(Console.ReadLine());
    serviceLista.Eliminar(datoBuscar);
    serviceLista.Recorrido();
    
} while (datoBuscar != 0);

Console.ReadLine();
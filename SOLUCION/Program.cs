// See https://aka.ms/new-console-template for more information
using System.Drawing;
using SOLUCION;
using static System.Runtime.InteropServices.JavaScript.JSType;

int respuesta = 1;
string r2;
Marihuana marihuana = new Marihuana();
Pbc pbc = new Pbc();
Tussi tussi = new Tussi();

do
{
    Console.Write("Cuantos datos ingresar: ");
    respuesta = int.Parse(Console.ReadLine());

} while (respuesta <= 0);
int[] arreglopreciom = new int[respuesta];
string[] arreglocalidad = new string[respuesta];
int[]  arreblopreciopbc= new int[respuesta];
int[] arreglopreciot=new int[respuesta];
string[] arreglocolor=new string[respuesta];    
 

int posicion = 0;
Console.WriteLine("Ingresa la droga con la que quieres volar");
r2=Console.ReadLine();

switch (r2)
{
    case "Mariguana":
        Console.WriteLine("Ingrese el precio:");
        marihuana.PrecioM = int.Parse(Console.ReadLine());
        arreglopreciom[posicion] = marihuana.PrecioM;
        Console.WriteLine("Ingrese la calidad que quiere");
        marihuana.Calidad = Console.ReadLine();
        arreglocalidad[posicion] = marihuana.Calidad;

        break;
    case "Tussi":
        Console.WriteLine("Ingresa el precio:");
        tussi.PrecioT = int.Parse(Console.ReadLine());
        arreglopreciot[posicion] = tussi.PrecioT;
        Console.WriteLine("Ingresa el color");
        tussi.Color = Console.ReadLine();
        arreglocolor[posicion] = tussi.Color;

        break;
    case "Pbc":
        Console.WriteLine("Precio:");
        pbc.PrecioPbc = int.Parse(Console.ReadLine());
        arreblopreciopbc[posicion] = pbc.PrecioPbc;

        break;

    case "mostrar":
        for (int i = 0; i < posicion; i++)
        {
            Console.Write("\n\n*precio*" + arreglopreciom[i] + "\nColor:" + arreglocolor[i] + "\npbc:" + arreblopreciopbc[i] + "\n\n*precio*" + arreglopreciom[i] + "\nColor:" + arreglocolor[i] + "\npbc:" + arreblopreciopbc[i] + " ");
        }
        break;
}
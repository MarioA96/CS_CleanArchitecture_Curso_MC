// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int number = 15;
// number = 20;

// float dec = 15.75f;
// double flotante = 12.43242;

// bool estado = false;

// string cadena = "Mi nombre";
// char caracter = 'c';

// var num = 93; // Inferencia de tipo
// num = "otra cosa" No es valido

// int[] numbers = new int[5];
// numbers[0] = 1;
// numbers[1] = 2;
// numbers[2] = 3;
// numbers[3] = 4;
// numbers[4] = 5;
// // number[5] = 6;

// int[] onumbers = new int[5]{
//     1,2,3,4,5
// };

// int[] inumbers = [1, 2, 3, 4, 5];
// System.Console.WriteLine(numbers[2]);

int limit = 10;
var beers = new string[limit];
int iBeers = 0;
int op = 0;

do
{
    Console.Clear();

    ShowMenu();

    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            if (iBeers < limit)
            {
                Console.Clear();
                Console.WriteLine("Escribe un nombre de cerveza: ");
                var beerName = Console.ReadLine();
                beers[iBeers] = beerName;
                iBeers++;
            }
            else
            {
                Console.WriteLine("Ya no caben cervezas");
            }
            break;
        case 2:
            ShowBeers(beers, iBeers);
            break;
        case 3:
            Console.WriteLine("Adios");
            break;
        default:
            Console.WriteLine("Opcion No Valida");
            break;
    }

} while (op != 3);

void ShowMenu()
{
    Console.WriteLine("1. Agregar nombre");
    Console.WriteLine("2. Mostrar nombre");
    Console.WriteLine("3. Salir");
}

void ShowBeers(string[] beers, int iBeers)
{
    Console.Clear();
    Console.WriteLine("--------Cervezas--------");
    for (int i = 0; i <= iBeers; i++)
    {
        Console.WriteLine(beers[i]);
    }

    Console.WriteLine("Presiona una tecla para continuar ...");
    Console.ReadLine();
}
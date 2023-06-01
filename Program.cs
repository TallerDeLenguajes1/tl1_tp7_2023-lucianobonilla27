// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
Calculadora num = new();
string input;
int menu;
float usuario;
do
{
    Console.WriteLine("Ingrese:");
    Console.WriteLine("1_ Sumar");
    Console.WriteLine("2_ Restar");
    Console.WriteLine("3_ Multiplicar");
    Console.WriteLine("4_ Dividir");
    Console.WriteLine("5_ Limpiar");
    Console.WriteLine("6_ Salir");

    input = Console.ReadLine();
    menu = int.Parse(input);

    switch (menu)
    {
        case 1:
          Console.WriteLine("Ingrese el numero a sumar:");
          input = Console.ReadLine();
          usuario = float.Parse(input);
          num.Sumar(usuario);
          Console.WriteLine("resultado = " + num.Resultado);
        break;

        case 2: 
          Console.WriteLine("Ingrese el numero a restar:");
          input = Console.ReadLine();
          usuario = float.Parse(input);
          num.Restar(usuario);
          Console.WriteLine("resultado = " + num.Resultado);
        break;

        
        case 3: 
          Console.WriteLine("Ingrese el numero a multiplitar:");
          input = Console.ReadLine();
          usuario = float.Parse(input);
          num.Multiplicar(usuario);
        Console.WriteLine("resultado = " + num.Resultado);

        break;

        
        case 4: 
          Console.WriteLine("Ingrese el numero a dividir:");
          input = Console.ReadLine();
          usuario = float.Parse(input);
          num.Dividir(usuario);
         Console.WriteLine("resultado = " + num.Resultado);

        break;

        
        case 5: 
          Console.WriteLine("Limpio:");
          num.Limpiar();
          Console.WriteLine("resultado = " + num.Resultado);

        break;


        case 6:
        Console.WriteLine("Adios!");
        break;

        default:
        Console.WriteLine("Ingrese un numero valido");
        break;
    }




} while (menu != 6);


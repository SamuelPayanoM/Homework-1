
// See https://aka.ms/new-console-template for more information

int numeroEntero = 10;
double numeroDouble = 3.1416;
float numeroFloat = 2.5f;
char letra = 'A';
string texto = "Hola C#";
bool esVerdadero = true;

Console.WriteLine("Todos los tipos de Variables ");
Console.WriteLine(numeroEntero);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroFloat);
Console.WriteLine(letra);
Console.WriteLine(texto);
Console.WriteLine(esVerdadero);


const double PI = 3.14159;
Console.WriteLine("constante");
Console.WriteLine(" valor de PI" + PI );

//PI = 4.8;




/* No se le puede cambiar la constante ya que el valor es unico, si se trata de cambiarla da un error de sintaxi
const string nickname = "Juan Antonio "; */

int contador = 5;

Console.WriteLine("\n *** Operaciones con entero *** ");
Console.WriteLine(" \n Valor Inicial: " + contador);


contador++;
Console.WriteLine(" \n Incrementado: " + contador);

contador--;
Console.WriteLine(" \n Ahora  decrementando: " + contador);

contador = contador + 10;
Console.WriteLine(" \n Sumandole 10: " + contador);

contador = contador * 2;
Console.WriteLine(" \n Multiplicado x2: " + contador);

Console.WriteLine("==========================");


float valorf = 10152466.25f;

byte valorB = (byte)(5 + valorf);

Console.WriteLine(" \n lo que vale Float: " + valorf);
Console.WriteLine(" \n  el Valor de byte: " + valorB);

DateTime fechaHoraActual = DateTime.Now;
Console.WriteLine(" \n Fecha Actual Del Sistema ");
Console.WriteLine(fechaHoraActual);



Console.ReadKey();
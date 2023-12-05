// See https://aka.ms/new-console-template for more information

int numero1=0;
int numero2=1;

int valor=0;

System.Console.WriteLine("Ingrese la posicion del numero de Fibonnaci:");

int posicion= int.Parse(Console.ReadLine());

for(int i=1;i<posicion; i++)
{
    valor=numero1+numero2;
    numero1=numero2;
    numero2=valor;
}

System.Console.WriteLine("El numero en la posicion " + posicion + "es " + valor);


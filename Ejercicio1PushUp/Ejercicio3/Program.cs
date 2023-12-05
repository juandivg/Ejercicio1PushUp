// See https://aka.ms/new-console-template for more information
int numero1=0;
int numero2=1;

int valor=0;

System.Console.WriteLine("Ingrese cuantos numeros de Fibonacci quiere:");

int cantidad= int.Parse(Console.ReadLine());
System.Console.WriteLine(numero1);
System.Console.WriteLine(numero2);

for(int i=2;i<cantidad; i++)
{
    
    valor=numero1+numero2;
    System.Console.WriteLine(valor);
    numero1=numero2;
    numero2=valor;
}


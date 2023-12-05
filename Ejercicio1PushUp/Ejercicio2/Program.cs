// See https://aka.ms/new-console-template for more information
int numero1=0;
int numero2=1;

int valor=0;

System.Console.WriteLine("Ingrese un numero:");

int numero= int.Parse(Console.ReadLine());

bool Fibonacci(int n)
{
    for(int i=1;i<100; i++)
{
    valor=numero1+numero2;
    numero1=numero2;
    numero2=valor;
    if(n==valor)
    {
        return true;
    }
}
return false;
}

if (Fibonacci(numero))
{
    System.Console.WriteLine("El numero "+numero + " es de fibonacci");
}
else{
    System.Console.WriteLine("El numero "+numero + " no es de fibonacci");
}


// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("Ingrese el multiplicador");

int multiplicador= int.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese el multiplicando");
int multiplicando= int.Parse(Console.ReadLine());


int sum=0;


while(multiplicador>=1)
{
    if(multiplicador%2==1){
        sum=sum+multiplicando;
    }
    multiplicando*=2;
    multiplicador/=2;

}

System.Console.WriteLine("El resultado es "+ sum);
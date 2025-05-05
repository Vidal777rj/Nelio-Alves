/*
var x = 10;
var name = "Michel";


System.Console.WriteLine(x.GetType());
System.Console.WriteLine(name.GetType());

System.Console.WriteLine("Digite um número de 1 á 7");
int n = int.Parse(Console.ReadLine());

string day;

switch (n)
{
    case 1:
        day = "Segunda - Feira";
        break;
    case 2:
        day = "Terça - Feira";
        break;
    case 3:
        day = "Quarta - Feira";
        break;
    case 4:
        day = "Quinta - Feira ";
        break;
    case 5:
        day = "Sexta - Feira";
        break;
    case 6:
        day = "Sabado";
        break;
    case 7:
        day = "Domingo";
        break;
    default:
        day =  "Digite um número valido";
        break;
}
*/

using System.Globalization;

Console.Write("Digite o valor: ");
double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
double desconto;

if (preco < 50)
{
    desconto = preco * 0.1;
}
else
{
    desconto = preco * 0.5;
}

Console.WriteLine(desconto);



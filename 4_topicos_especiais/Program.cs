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
*/


/*Funções interessantes 
string original = "Michel Vidal de Oliveira";
string original2 = " ";

string s1 = original.ToUpper();
string s2 = original.ToLower();
string s3 = original.Trim();

int n1 = original.IndexOf("Vi");

string s4 = original.Substring(15);
string s5 = original.Replace("Michel", "Mikaella");
string s6 = original.Replace("Vidal", "Vieira");
bool s7 = String.IsNullOrEmpty(original);
bool s8 = string.IsNullOrWhiteSpace(original);

bool s9 = String.IsNullOrEmpty(original2);
bool s10 = string.IsNullOrWhiteSpace(original2);



System.Console.WriteLine($"Original: {original}");
System.Console.WriteLine($"ToUpper: {s1}");
System.Console.WriteLine($"ToLower: {s2}");
System.Console.WriteLine($"Trim: {s3}");
System.Console.WriteLine($"IndexOf: {n1}");
System.Console.WriteLine($"Substring: {s4}");
System.Console.WriteLine($"Replace: {s5}");
System.Console.WriteLine($"Replace: {s6}");
System.Console.WriteLine($"IsNullOrEmpty - Nulo ou Vazio: {s7}");
System.Console.WriteLine($"IsNullOrWhiteSpace - Nulo ou Espaço em Branco: {s8}");

System.Console.WriteLine($"IsNullOrEmpty - Nulo ou Vazio: {s9}");
System.Console.WriteLine($"IsNullOrWhiteSpace - Nulo ou Espaço em Branco: {s10}");

*/

/*DateTime

DateTime d1 = DateTime.Now;
DateTime d2 = DateTime.Today;
DateTime d3 = DateTime.Parse("2025-05-06");
DateTime horaGlobal = DateTime.UtcNow;
System.Console.WriteLine("" + d1);
System.Console.WriteLine("" + d1.Ticks);
System.Console.WriteLine(horaGlobal);
System.Console.WriteLine(d2);
System.Console.WriteLine(d3);

System.Console.WriteLine(d1.Minute);
System.Console.WriteLine(d1.AddDays(1));


static string DiaOuNoite()
{
    int pegarHorario = DateTime.Now.Hour;
    string saudacao;
    if (pegarHorario < 12)
    {
        saudacao = $"Bom dia - {pegarHorario}";
    }
    else if (pegarHorario < 18)
    {
        saudacao = $"Boa tarde - {pegarHorario}";
    }
    else
    {
        saudacao = $"Boa noite - {pegarHorario}";
    }
    return saudacao;
};

System.Console.WriteLine(DiaOuNoite());
*/

/*ENUM*/

using _4_topicos_especiais.Entities;
using _4_topicos_especiais.enums;

Order order = new Order()
{
    Id = 1000,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

System.Console.WriteLine(order);

string txt = OrderStatus.PendingPayment.ToString();

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
System.Console.WriteLine(os);
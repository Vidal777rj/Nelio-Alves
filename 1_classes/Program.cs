using System.Globalization;
using _1_classes;
/*
---------- Sem ORIETAÇÃO A OBJETOS ----------
double xA, xB, xC, yA, yB, yC;

Console.WriteLine("Entre com as medidas da triângulo X:");

xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Entre com as medidas da triângulo Y:");
yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC) / 2.0;
double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

p = (yA + yB + yC) / 2.0;
double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

Console.WriteLine($"Área de X =  {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Área de Y =  {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

if (areaX > areaY)
{
    Console.WriteLine("A maior área: X");
}else{
    System.Console.WriteLine("Maior área: Y");
}
*/

/* ---------- Com classes ---------- 
Triangulo x, y;

x = new Triangulo();
y = new Triangulo();


Console.WriteLine("Entre com as medidas da triângulo X:");

x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Entre com as medidas da triângulo Y:");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (x.A + x.B + x.C) / 2.0;
double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

p = (y.A + y.B + y.C) / 2.0;
double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

Console.WriteLine($"Área de X =  {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Área de Y =  {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

if (areaX > areaY)
{
   Console.WriteLine("A maior área: X");
}
else
{
   System.Console.WriteLine("Maior área: Y");
}

*/


/* Exercicio - Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha 

Console.WriteLine("Digite o nome da primeira pessoa: ");
string nome1 = Console.ReadLine();

Console.WriteLine("Digite a idade da primeira pessoa: ");
int idade1 = int.Parse(Console.ReadLine());
Pessoa pessoa1 = new Pessoa(nome1, idade1);

Console.WriteLine("Digite o nome da segunda pessoa: ");
string nome2 = Console.ReadLine();

Console.WriteLine("Digite a idade da segunda pessoa: ");
int idade2 = int.Parse(Console.ReadLine());
Pessoa pessoa2 = new Pessoa(nome2, idade2);

Pessoa maisVelha = Pessoa.PessoaMaisVelha(pessoa1, pessoa2);
Console.WriteLine($"Pessoa mais velha {maisVelha.Nome}");

*/

/*
Produto p = new()
{

};

Console.WriteLine("Entre os dados de produto");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();

Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine($"Dados do produto {p.Nome}, R$ {p.Preco}, {p.Quantidade} ");

Console.Write("Digite o número de produtos a ser adicionado: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProduto(qte);

Console.WriteLine("Digite a quantidade a ser removido");
int qteRemover = int.Parse(Console.ReadLine());
p.RevoverProduto(qteRemover);
Console.WriteLine($"Dados atualizado {p}");
*/
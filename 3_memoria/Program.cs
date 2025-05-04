
using System.Globalization;
using _3_memoria;
using Point = _3_memoria.Point;

/*A struct (estrutura) em programação é um tipo de dado composto que agrupa variáveis sob um mesmo nome. Essas variáveis
 podem ser de tipos diferentes e são chamadas de membros ou campos da estrutura. structs são muito utilizadas para representar 
 objetos ou entidades com diversas características.*/
/*
Point p;
p.x = 1;
p.y = 1;
Console.WriteLine(p);

double? x = null;
double? y = 10.22;

Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(y.GetValueOrDefault());


if(x.HasValue)
 Console.WriteLine(x.Value);
else
 Console.WriteLine("X is null");
 */
 
 /*Vetores
 //Fazer um programa para ler um número inteiro N e a altura de N pessoas, armazene as informações em um vetor
 int n = int.Parse(Console.ReadLine());
 
 double[] vect = new double[n];
 
 for(int i = 0; i < n; i++)
 {
   vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 } 
 double sum = 0.0;
 for (int i = 0; i < n; i++)
 {
  sum += vect[i];
 }
 
 double avg = sum / n;
 Console.WriteLine(avg.ToString(CultureInfo.InvariantCulture));
 */
 
 /* Vetores 2
 Console.Write("Digite a quantidade de produtos a ser inserido: ");
 int n = int.Parse(Console.ReadLine());
 
 Product[] vect = new Product[n];
 for (int i = 0; i < n; i++)
 { 
     Console.Write("Digite o nome do produto: ");
   string name = Console.ReadLine();
   
   Console.Write("Digite o preço do produto: ");
   double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   
   vect[i] = new Product{ Name = name, Price = price };
 }
 
 double soma = 0.0;
 for (int i = 0; i < vect.Length; i++)
 {
   soma += vect[i].Price;
 }
 
 double mediaPreco = soma / n;

 Console.WriteLine($"Preço médio: {mediaPreco:F2}");
 */
 
Console.Write("Digite a quantidade de passageiros a ser inserido na viagem: ");
 int n = int.Parse(Console.ReadLine());
 
 Passageiro[] vetor = new Passageiro[n];

 for (int i = 0; i < n; i++)
 {
  Console.Write("Digite o nome do passageiro: ");
  string nome = Console.ReadLine();
  
  Console.Write("Digite a poltrona do passageiro: ");
  int poltrona = int.Parse(Console.ReadLine());

  vetor[i] = new Passageiro { Nome = nome, Assento = poltrona };
  
  Console.WriteLine($"Passageiro da viagem: {vetor[i].Nome} - {vetor[i].Assento}");
 }
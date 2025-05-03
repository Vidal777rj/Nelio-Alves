using System.Globalization;
using _2_construtores;

Produto p = new("TV", 205.50, 10);

Console.WriteLine("--Entre os dados de produto--");

Console.Write("Nome: ");
p.Nome = Console.ReadLine();

Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



Console.Write("Digite o número de produtos a ser adicionado: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProduto(qte);


Console.WriteLine("Digite a quantidade a ser removido");
int qteRemover = int.Parse(Console.ReadLine());
p.RemoverProduto(qteRemover);
Console.WriteLine($"Dados atualizado {p.Quantidade}");
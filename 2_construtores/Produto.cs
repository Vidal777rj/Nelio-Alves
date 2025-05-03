namespace _2_construtores
{
    public class Produto
    {
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        //é um método especial usado para inicializar um objeto quando ele é criado. Ele normalmente tem o mesmo 
        // nome da classe e é chamado automaticamente no momento da instanciação. Em linguagens como C#, Java e C++, 
        // o construtor pode ser usado para atribuir valores iniciais aos atributos do objeto ou para executar rotinas de 
        // configuração.
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {

            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {

            Quantidade -= quantidade;

        }

        public override string ToString()
        {
            return $"{Nome}, R${Preco}";
        }
    }
}

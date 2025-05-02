
using System.ComponentModel.DataAnnotations.Schema;

namespace _1_classes
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public static Pessoa PessoaMaisVelha(Pessoa p1, Pessoa p2)
        {
            if (p1.Idade > p2.Idade)
            {
                return p1;
            }
            else
            {
                return p2;

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo.Jogos.Entities
{
    public class Jogo
    {
        public Jogo(Guid id, string nome, string produtora, double preco)
        {
            Id = id;
            Nome = nome;
            Produtora = produtora;
            Preco = preco;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Produtora { get; private set; }
        public double Preco { get; private set; }
    }
}

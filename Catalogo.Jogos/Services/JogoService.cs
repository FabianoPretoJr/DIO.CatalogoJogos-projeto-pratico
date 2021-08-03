using Catalogo.Jogos.Entities;
using Catalogo.Jogos.InputModel;
using Catalogo.Jogos.Repositories;
using Catalogo.Jogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo.Jogos.Services
{
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _jogoRepository;

        public JogoService(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }

        public async Task<List<JogoViewModel>> Obter(int pagina, int quantidade)
        {
            var jogos = await _jogoRepository.Obter(pagina, quantidade);

            return jogos.Select(jogo => new JogoViewModel
            {
                Id = jogo.Id,
                Nome = jogo.Nome,
                Produtora = jogo.Produtora,
                Preco = jogo.Preco
            }).ToList();
        }

        public Task Atualizar(Guid id, JogoInputModel jogo)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Guid id, double preco)
        {
            throw new NotImplementedException();
        }

        public Task<JogoViewModel> Inserir(JogoInputModel jogo)
        {
            throw new NotImplementedException();
        }

        public Task<JogoViewModel> Obter(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _jogoRepository?.Dispose();
        }
    }
}

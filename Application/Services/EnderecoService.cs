using Application.Adapters;
using Domains.Entidades;
using Domains.Interfaces.Repository;
using Domains.Interfaces.Services;
using Domains.Models;

namespace Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;

        public EnderecoService(IEnderecoRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(List<EnderecoModel> enderecos)
        {
            var domains = EnderecoAdapter.Map(enderecos);
            await _repository.Add(domains);
        }

        public async Task AtualizarDados(EnderecoModel endereco)
        {
            var domain = await _repository.Get(endereco.Id);
            if (domain == null)
            {
                throw new Exception("Cep não Localizado");
            }
            domain.Logadouro = endereco.Logadouro;
            domain.Bairro = endereco.Bairro;
            domain.Status = Domains.Enums.EnumStatus.Finalizado;

            await _repository.AtualizarDados(domain);            
        }

        public async Task<List<EnderecoModel>> List()
        {
            var enderecos = await _repository.List();
            return EnderecoAdapter.Map(enderecos);
        }

        public async Task<EnderecoModel> ObterCepParaTratamento(string robo0)
        {
            var domain = await _repository.ObterCepParaTratamento(robo0);
            domain.Status = Domains.Enums.EnumStatus.EmAndamento;
            domain.Robo = robo0;

            _repository.AtualizarDados(domain);
            return EnderecoAdapter.Map(domain);
        }
    }
}

using Domains.Models;

namespace Domains.Interfaces.Services
{
    public interface IEnderecoService
    {
        Task Add(List<EnderecoModel> enderecos);
        Task AtualizarDados(EnderecoModel endereco);
        Task<EnderecoModel> ObterCepParaTratamento(string robo0);
        Task<List<EnderecoModel>> List();
    }
}

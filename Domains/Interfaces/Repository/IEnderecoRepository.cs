using Domains.Entidades;

namespace Domains.Interfaces.Repository
{
    public interface IEnderecoRepository
    {
        Task Add(List<Endereco> enderecos);
        Task AtualizarDados(Endereco endereco);
        Task<Endereco> ObterCepParaTratamento(string robo0);
        Task<Endereco> Get(int id);
        Task<List<Endereco>> List();
    }
}

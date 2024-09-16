using Domains.Entidades;
using Domains.Interfaces.Repository;
using EFCore.BulkExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly ProjectDbContext _context;

        public EnderecoRepository(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task Add(List<Endereco> enderecos)
        {
            await _context.BulkInsertAsync(enderecos);
        }

        public async Task AtualizarDados(Endereco endereco)
        {
            _context.Enderecos.Update(endereco);
            await _context.SaveChangesAsync();
           
        }

        public async Task<Endereco?> Get(int id)
        {
            return _context.Enderecos.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<List<Endereco>> List()
        {
            return _context.Enderecos.ToList();
        }

        public async Task<Endereco?> ObterCepParaTratamento(string robo0)
        {
            var cep = _context.Enderecos.Where(x =>
            (x.Status == Domains.Enums.EnumStatus.EmAndamento && x.Robo == robo0)
                ||
            (x.Status == Domains.Enums.EnumStatus.Aberto && string.IsNullOrEmpty(x.Robo))
            ).FirstOrDefault();
            return cep;
        }
    }
}

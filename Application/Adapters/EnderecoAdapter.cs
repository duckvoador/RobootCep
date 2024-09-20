using Domains.Entidades;
using Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Adapters
{
    public class EnderecoAdapter
    {
        public static EnderecoModel Map(Endereco endereco) 
        {
            var model = new EnderecoModel();
            model.Id = endereco.Id;
            model.CEP = endereco.CEP;
            model.Logadouro = endereco.Logadouro;
            model.Bairro = endereco.Bairro;
            model.UF = endereco.UF;
            return model;
        }
        public static Endereco Map(EnderecoModel endereco)
        {
            var model = new Endereco();
            model.Id = endereco.Id;
            model.CEP = endereco.CEP;
            model.Logadouro = endereco.Logadouro;
            model.Bairro = endereco.Bairro;
            model.UF = endereco.UF;
            return model;
        }
        public static List<EnderecoModel> Map(List<Endereco> endereco) 
        {
            return endereco.Select(Map).ToList();
        }
        public static List<Endereco> Map(List<EnderecoModel> endereco)
        {
            return endereco.Select(Map).ToList();
        }
    }


}

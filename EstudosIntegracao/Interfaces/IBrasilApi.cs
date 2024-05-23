using EstudosIntegracao.Dtos;
using EstudosIntegracao.Models;

namespace EstudosIntegracao.Interfaces;

public interface IBrasilApi
{
    Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoCep(string cep);
    Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
    Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
}

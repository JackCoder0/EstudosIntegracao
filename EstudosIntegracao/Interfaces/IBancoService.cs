using EstudosIntegracao.Dtos;

namespace EstudosIntegracao.Interfaces;

public interface IBancoService
{
    Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();
    Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
}

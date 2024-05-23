using EstudosIntegracao.Dtos;

namespace EstudosIntegracao.Interfaces;

public interface IEnderecoService
{
    Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
}

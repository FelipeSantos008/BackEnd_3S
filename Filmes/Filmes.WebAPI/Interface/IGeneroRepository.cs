using Filmes.WebAPI.Models;

namespace Filmes.WebAPI.Interface;

public interface IGeneroRepository
{
    void Cadastrar(Genero novoGenero);
    void AtualizarIdCorpo(Genero generoAtualizado);
    void AtualizarIdUtl(Guid id, Genero generoAtualizado);
    List<Genero> Listar();
    void Deletar(Guid id);
    Genero BuscarPorId(Guid id);
}

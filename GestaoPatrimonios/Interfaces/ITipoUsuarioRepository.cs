using GestaoDePatrimonios.Domains;
namespace GestaoDePatrimonios.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();
        TipoUsuario BuscarPorId(Guid tipoUsuarioId);
        TipoUsuario BuscarPorNome(string nomeTipo);
        void Adicionar(TipoUsuario tipoUsuario);
        void Atualizar(TipoUsuario tipoUsuario);
    }
}

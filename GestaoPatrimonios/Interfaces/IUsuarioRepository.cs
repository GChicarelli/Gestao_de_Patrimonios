using GestaoDePatrimonios.Domains;


namespace GestaoDePatrimonios.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();
    }
}

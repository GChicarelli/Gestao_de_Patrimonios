using GestaoDePatrimonios.Contexts;
using GestaoDePatrimonios.Domains;

using GestaoDePatrimonios.Interfaces;

namespace GestaoDePatrimonios.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly GestaoDePatrimoniosContext _context;

        public UsuarioRepository(GestaoDePatrimoniosContext context)
        {
            _context = context;
        }

        public List<Usuario> Listar()
        {
            return _context.Usuario.OrderBy(usuario => usuario.Nome).ToList();
        }

    }
}

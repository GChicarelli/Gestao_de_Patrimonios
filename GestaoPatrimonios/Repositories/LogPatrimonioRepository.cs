using GestaoDePatrimonios.Contexts;
using GestaoDePatrimonios.Domains;
using GestaoPatrimonios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GestaoPatrimonios.Repositories
{
    public class LogPatrimonioRepository : ILogPatrimonioRepository
    {
        private readonly GestaoDePatrimoniosContext _context;

        public LogPatrimonioRepository(GestaoDePatrimoniosContext context)
        {
            _context = context;
        }

        public List<LogPatrimonio> Listar()
        {
            return _context.LogPatrimonio
                .Include(log => log.Usuario)
                .Include(log => log.Localizacao)
                .Include(log => log.TipoAlteracao)
                .Include(log => log.StatusPatrimonio)
                .Include(log => log.Patrimonio)
                .OrderByDescending(log => log.DataTransferencia)
                .ToList();
        }

        public List<LogPatrimonio> BuscarPorPatrimonio(Guid patrimonioId)
        {
            return _context.LogPatrimonio
                .Include(log => log.Usuario)
                .Include(log => log.Localizacao)
                .Include(log => log.TipoAlteracao)
                .Include(log => log.StatusPatrimonio)
                .Include(log => log.Patrimonio)
                .Where(log => log.PatrimonioID == patrimonioId)
                .OrderByDescending(log => log.DataTransferencia)
                .ToList();
        }


    }
}

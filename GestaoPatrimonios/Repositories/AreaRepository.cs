using GestaoDePatrimonios.Contexts;
using GestaoDePatrimonios.Domains;
using GestaoDePatrimonios.Interfaces;

namespace GestaoDePatrimonios.Repositories
{
    public class AreaRepository : IAreaRepository
    {
        private readonly GestaoDePatrimoniosContext _context;

        public AreaRepository(GestaoDePatrimoniosContext context)
        {
            _context = context;
        }

        public List<Area> Listar()
        {
            return _context.Area.OrderBy(area => area.NomeArea).ToList();
        }

        public Area BuscarPorId(Guid areaId)
        {
            return _context.Area.Find(areaId);
        }

        public Area BuscarPorNome(string nomeArea)
        {
            return _context.Area.FirstOrDefault(area => area.NomeArea.ToLower() == nomeArea.ToLower());
        }

        public void Adicionar(Area area)
        {
            _context.Area.Add(area);
            _context.SaveChanges();
        }

        public void Atualizar(Area area)
        {
            if(area == null)
            {
                return;
            }

            Area areaBanco = _context.Area.Find(area.AreaID);

            if (area == null)
            {
                return;
            }

            areaBanco.NomeArea = area.NomeArea;
            _context.SaveChanges();
        }
    }
}

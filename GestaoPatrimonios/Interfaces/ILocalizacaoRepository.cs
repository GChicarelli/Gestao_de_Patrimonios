using GestaoDePatrimonios.Domains;

namespace GestaoDePatrimonios.Interfaces
{
    public interface ILocalizacaoRepository
    {
       public List<Localizacao> Listar();
       public Localizacao BuscarPorId(Guid localizacaoId);
       public void Adicionar(Localizacao localizacao);
       public bool AreaExiste(Guid areaId);
       public void Atualizar(Localizacao localizacao);
       public Localizacao BuscarPorNome(string nomeLocal, Guid areaId);
    }
}

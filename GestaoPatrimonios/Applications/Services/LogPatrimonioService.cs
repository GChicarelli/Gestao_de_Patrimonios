using GestaoDePatrimonios.DTOs.AreaDto;
using GestaoPatrimonios.DTOs.LogPatrimonioDto;
using GestaoPatrimonios.Interfaces;

namespace GestaoPatrimonios.Applications.Services
{
    public class LogPatrimonioService
    {
        private readonly ILogPatrimonioRepository _repository;

        public LogPatrimonioService(ILogPatrimonioRepository repository)
        {
            _repository = repository;
        }

        public List<ListarLogPatrimonioDto> Listar()
        {
            List<LogPatrimonio> logs = _repository.Listar();

            List<ListarLogPatrimonioDto> logsDto = logs.Select(log => new ListarLogPatrimonioDto
            {
                LogPatrimonioID = log.LogPatrimonioID,
                DataTrasferencia = log.DataTrasferencia,
                PatrimonioID = log.PatrimonioID,
                DenominacaoPatrionio = log.DenominacaoPatrionio,
                TipoAlteracao = log.TipoAlteracao,
                StatusPatrimonio = log.StatusPatrimonio.NomeStatus
            })
        }
    }
}

using System;
using System.Collections.Generic;

namespace WebApplication1.Domains;

public partial class StatusTransferencia
{
    public Guid StatusTransferenciaID { get; set; }

    public string NomeStatus { get; set; } = null!;

    public virtual ICollection<SolicitacaoTransferencia> SolicitacaoTransferencia { get; set; } = new List<SolicitacaoTransferencia>();
}

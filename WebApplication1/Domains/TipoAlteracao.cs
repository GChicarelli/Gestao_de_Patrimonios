using System;
using System.Collections.Generic;

namespace WebApplication1.Domains;

public partial class TipoAlteracao
{
    public Guid TipoAlteracaoID { get; set; }

    public string NomeTipo { get; set; } = null!;

    public virtual ICollection<LogPatrimonio> LogPatrimonio { get; set; } = new List<LogPatrimonio>();
}

using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class CultivoVariedad
{
    public int CultVarId { get; set; }

    public int CultId { get; set; }

    public string? CultVarDescripcion { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }

    public virtual Cultivo Cult { get; set; } = null!;

    public virtual ICollection<CultivoSembrado> CultivoSembrados { get; } = new List<CultivoSembrado>();
}

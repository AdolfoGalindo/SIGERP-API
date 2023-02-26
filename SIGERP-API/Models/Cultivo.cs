using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class Cultivo
{
    public int CultId { get; set; }

    public string? CultDescripcion { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }

    public virtual ICollection<CultivoVariedad> CultivoVariedads { get; } = new List<CultivoVariedad>();
}

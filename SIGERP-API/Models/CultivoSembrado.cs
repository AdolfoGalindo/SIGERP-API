using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class CultivoSembrado
{
    public int CultSembId { get; set; }

    public int? CampId { get; set; }

    public int? CultVariedId { get; set; }

    public DateTime? CultSembFecInic { get; set; }

    public DateTime? CultSembFecFin { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }

    public virtual CampoCultivo? Camp { get; set; }

    public virtual CultivoVariedad? CultVaried { get; set; }
}

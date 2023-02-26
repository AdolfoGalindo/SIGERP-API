using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class UbicacionZona
{
    public int UbicZonaId { get; set; }

    public int? UbicSectId { get; set; }

    public string? UbiZonaDescripcion { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }

    public virtual ICollection<CampoCultivo> CampoCultivos { get; } = new List<CampoCultivo>();

    public virtual UbicacionSector? UbicSect { get; set; }
}

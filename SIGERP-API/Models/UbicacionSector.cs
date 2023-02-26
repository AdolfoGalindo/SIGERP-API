using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class UbicacionSector
{
    public int UbicSectId { get; set; }

    public string? UbicSectDescripcion { get; set; }

    public string? UbicSectAbrev { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }

    public virtual ICollection<UbicacionZona> UbicacionZonas { get; } = new List<UbicacionZona>();
}

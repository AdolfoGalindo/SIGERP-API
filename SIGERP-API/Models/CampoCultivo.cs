using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class CampoCultivo
{
    public int CampId { get; set; }

    public string? CampDescripcion { get; set; }

    public string? CampCategSuelo { get; set; }

    public string? CampIdAnterior { get; set; }

    public int? UnidOrgId { get; set; }

    public int? UbicZonaId { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }

    public virtual ICollection<CultivoSembrado> CultivoSembrados { get; } = new List<CultivoSembrado>();

    public virtual UbicacionZona? UbicZona { get; set; }

    public virtual UnidadOrganizativa? UnidOrg { get; set; }
}

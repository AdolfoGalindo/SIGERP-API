using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class UnidadOrganizativa
{
    public int UnidOrgId { get; set; }

    public string? UnidOrgDescripcion { get; set; }

    public string? UnidOrgNivel01 { get; set; }

    public string? UnidOrgNivel02 { get; set; }

    public string? UnidOrgNivel03 { get; set; }

    public string? UnidOrgNivel04 { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }

    public virtual ICollection<CampoCultivo> CampoCultivos { get; } = new List<CampoCultivo>();
}

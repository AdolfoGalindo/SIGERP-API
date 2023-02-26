using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class Usuario
{
    public string UsuaId { get; set; } = null!;

    public string UsuaApePat { get; set; } = null!;

    public string UsuaApeMat { get; set; } = null!;

    public string UsuaNombres { get; set; } = null!;

    public string UsuaDni { get; set; } = null!;

    public string UsuaDireccion { get; set; } = null!;

    public string DptoGeoId { get; set; } = null!;

    public string ProvGeoId { get; set; } = null!;

    public string DistGeoId { get; set; } = null!;

    public string? UsuaParametros { get; set; }

    public int? UsuaEstado { get; set; }

    public string? TrabId { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }
}

using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class Sociedad
{
    public int SociedadId { get; set; }

    public string? SociedadDescripcion { get; set; }

    public string? SociedadRazSocial { get; set; }

    public string? SociedadTelef01 { get; set; }

    public string? SociedadTelef02 { get; set; }

    public string? SociedadTelef03 { get; set; }

    public string? SociedadRuc { get; set; }

    public string? SociedadFax { get; set; }

    public string? SociedadDirecc { get; set; }

    public string? SociedadAbrev { get; set; }

    public string? SociedadCiudad { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }
}

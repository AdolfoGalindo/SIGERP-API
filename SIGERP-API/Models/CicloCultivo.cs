using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class CicloCultivo
{
    public long CicloCultId { get; set; }

    public string? ProdId { get; set; }

    public string? CampId { get; set; }

    public int? NumeroCiclo { get; set; }

    public int? NumeroCorte { get; set; }

    public DateTime? FechaSiembra { get; set; }

    public DateTime? FechaInicioCult { get; set; }

    public DateTime? FechaAgoste { get; set; }

    public string? CicloCultCorrCorte { get; set; }

    public string? CicloCultVaried { get; set; }

    public string? CicloCultEstado { get; set; }

    public string? CencCostId { get; set; }

    public string? OrdTrabId { get; set; }

    public string? CodTitanium { get; set; }

    public decimal? CicloCultHasNeta { get; set; }

    public decimal? CicloCultHasbruta { get; set; }

    public decimal? CicloCultHasNetaPpto { get; set; }

    public string? CicloCultTipo { get; set; }

    public string? CicloCultCond { get; set; }

    public string? CicloCultTipSuel { get; set; }

    public string? CicloCultTextura { get; set; }

    public string? CicloCultDren { get; set; }

    public decimal? CicloCultProfSuel { get; set; }

    public decimal? CicloCultLongSurc { get; set; }

    public string? CicloCultTipCamino { get; set; }

    public string? CicloCultFnteAgua { get; set; }

    public string? CicloCultDispAgua { get; set; }

    public string? CicloCultAnterior { get; set; }

    public string? CicloCultPiedra { get; set; }

    public decimal? CicloCultPiedraPorc { get; set; }

    public string? CicloCultSistRiego { get; set; }

    public string? CicloCultObs { get; set; }

    public string? CicloCultSituaCont { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }
}

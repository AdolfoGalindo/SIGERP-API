using System;
using System.Collections.Generic;

namespace SIGERP_API.Models;

public partial class FactProduccion
{
    public long CicloCultId { get; set; }

    public int NumCosech { get; set; }

    public int? AnoCosech { get; set; }

    public int? MesCosech { get; set; }

    public string CampId { get; set; } = null!;

    public string? ProdId { get; set; }

    public decimal? EdadPpto { get; set; }

    public decimal? RendHaPpto { get; set; }

    public decimal? SacarosaPpto { get; set; }

    public decimal? TonPpto { get; set; }

    public decimal? Tchmppto { get; set; }

    public decimal? Tshmppto { get; set; }

    public string? CostoEstimado { get; set; }

    public DateTime? FechaIniCosecha { get; set; }

    public DateTime? FechaFinCosecha { get; set; }

    public int? DiasCosecha { get; set; }

    public decimal? EdadCosecha { get; set; }

    public decimal? AreaCosechada { get; set; }

    public decimal? TonCosechada { get; set; }

    public decimal? TonMateriaExtraña { get; set; }

    public decimal? TonCañaNeta { get; set; }

    public decimal? Sacarosa { get; set; }

    public decimal? RendTchc { get; set; }

    public decimal? ProdTchm { get; set; }

    public decimal? ProdTshm { get; set; }

    public decimal? ProdAzucarKg { get; set; }

    public decimal? ProdAzucarBls { get; set; }

    public decimal? ProdAzucarBlsTn { get; set; }

    public decimal? ProdAzucarKgTn { get; set; }

    public decimal? Extraccion { get; set; }

    public decimal? Retencion { get; set; }

    public decimal? Recobrado { get; set; }

    public decimal? PolJp { get; set; }

    public decimal? PurezaJp { get; set; }

    public decimal? RedJp { get; set; }

    public decimal? JavaRatio { get; set; }

    public decimal? PorcImpureza { get; set; }

    public decimal? RendReal { get; set; }

    public decimal? CostoReal { get; set; }

    public decimal? CostoPpto { get; set; }

    public decimal? PrecioUnit { get; set; }

    public decimal? Ingreso { get; set; }

    public decimal? Utilidad { get; set; }

    public string? NumLiq { get; set; }

    public string? EstCicloCult { get; set; }

    public string? ObjId { get; set; }

    public decimal? Preparacion { get; set; }

    public decimal? Siembra { get; set; }

    public decimal? Cultivo { get; set; }

    public decimal? Corte { get; set; }

    public decimal? Carguio { get; set; }

    public decimal? Recojo { get; set; }

    public decimal? Transporte { get; set; }

    public decimal? Administrativo { get; set; }

    public string? UsrSistema { get; set; }

    public DateTime? FecHrsSistema { get; set; }
}

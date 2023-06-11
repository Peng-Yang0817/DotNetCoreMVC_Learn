using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class NformAnnex7Step1
{
    public int Id { get; set; }

    /// <summary>
    /// 學制代碼
    /// </summary>
    public string? EducationSystemCode { get; set; }

    /// <summary>
    /// 總量學制
    /// </summary>
    public string? EducationSystemName { get; set; }

    /// <summary>
    /// 學制1
    /// </summary>
    public string? SystemOne { get; set; }

    /// <summary>
    /// 學制2
    /// </summary>
    public string? SystemTwo { get; set; }

    /// <summary>
    /// 生師比加權數
    /// </summary>
    public decimal? Weighted { get; set; }

    /// <summary>
    /// 擴充比率
    /// </summary>
    public decimal? ExpansionRatio { get; set; }

    /// <summary>
    /// 外加時學制加權
    /// </summary>
    public int? ExternalWeighted { get; set; }

    public string? NationalOrPrivate { get; set; }
}

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl008
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 高職招生系所名稱
    /// </summary>
    public string GauJrGuoJungGuoShiauBuName { get; set; } = null!;

    /// <summary>
    /// FK SchoolCtrl001 高職招生學校 ID
    /// </summary>
    public int? SchoolCtrl001Id { get; set; }

    /// <summary>
    /// 高職部招生班別名稱
    /// </summary>
    public string? ClassName { get; set; }

    /// <summary>
    /// 高職部招生群別名稱
    /// </summary>
    public string? GroupName { get; set; }

    /// <summary>
    /// 高職部招生類別名稱
    /// </summary>
    public string? CategoryName { get; set; }

    /// <summary>
    /// FK SchoolCtrl003 領域別ID
    /// </summary>
    public int SchoolCtrl003Id { get; set; }

    /// <summary>
    /// 高職部招生校基庫代碼
    /// </summary>
    public string? DepartmentNum { get; set; }

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    /// <summary>
    /// FK State005 管制類ID
    /// </summary>
    public int? State005Id { get; set; }

    /// <summary>
    /// FK State009 護理農業化工及土木領域ID
    /// </summary>
    public int? State009Id { get; set; }

    /// <summary>
    /// FK State010 總量統計用領域別ID
    /// </summary>
    public int? State010Id { get; set; }

    /// <summary>
    /// 高職部招生建立時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 高職部招生建立者ID
    /// </summary>
    public int Auth001Id { get; set; }
}

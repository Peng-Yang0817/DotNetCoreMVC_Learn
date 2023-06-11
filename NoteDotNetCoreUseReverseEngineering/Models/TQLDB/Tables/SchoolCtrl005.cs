using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl005
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 大學部系所名稱
    /// </summary>
    public string DaShiueBuName { get; set; } = null!;

    /// <summary>
    /// FK SchoolCtrl002 院代碼
    /// </summary>
    public int? SchoolCtrl002Id { get; set; }

    /// <summary>
    /// 大學部班名稱
    /// </summary>
    public string? ClassName { get; set; }

    /// <summary>
    /// 大學部組名稱
    /// </summary>
    public string? GroupName { get; set; }

    /// <summary>
    /// 大學部類別名稱
    /// </summary>
    public string? CategoryName { get; set; }

    /// <summary>
    /// FK SchoolCtrl003 領域別ID
    /// </summary>
    public int SchoolCtrl003Id { get; set; }

    /// <summary>
    /// 校基庫系所代碼
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
    /// 大學部建立時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 大學部建立者ID
    /// </summary>
    public int Auth001Id { get; set; }

    public string? ClassGroupCode { get; set; }

    public string? TotalDepartmentCode { get; set; }
}

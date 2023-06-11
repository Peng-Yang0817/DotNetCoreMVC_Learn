using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl004
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 碩博士班名稱 (3階 表一)
    /// </summary>
    public string ShuoBoShrBanName { get; set; } = null!;

    /// <summary>
    /// FK SchoolCtrl002 學院ID
    /// </summary>
    public int? SchoolCtrl002Id { get; set; }

    /// <summary>
    /// 班別名稱
    /// </summary>
    public string? ClassName { get; set; }

    /// <summary>
    /// 組別名稱
    /// </summary>
    public string? GroupName { get; set; }

    /// <summary>
    /// 類別名稱
    /// </summary>
    public string? CategoryName { get; set; }

    /// <summary>
    /// FK SchoolCtrl003 教育部領域別ID
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
    /// 碩博班建立時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 碩博班建立者
    /// </summary>
    public int Auth001Id { get; set; }

    public string? ClassGroupCode { get; set; }

    public string? TotalDepartmentCode { get; set; }
}

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl013
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl007 舊高職、國中、國小 ID
    /// </summary>
    public int OldSchoolCtrl008Id { get; set; }

    /// <summary>
    /// FK State002 系科所狀態 ID
    /// </summary>
    public int State002Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl007 新高職、國中、國小 ID
    /// </summary>
    public int? NewSchoolCtrl008Id { get; set; }

    /// <summary>
    /// 舊高職、國中、國小系所名稱
    /// </summary>
    public string? OldGauJrGuoJungGuoShiauBuName { get; set; }

    /// <summary>
    /// 舊班別名稱
    /// </summary>
    public string? OldClassName { get; set; }

    /// <summary>
    /// 舊組別名稱
    /// </summary>
    public string? OldGroupName { get; set; }

    /// <summary>
    /// 高職、國中、國小狀態改變年度
    /// </summary>
    public string Year { get; set; } = null!;

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    /// <summary>
    /// 高職
    /// </summary>
    public bool GauJrShengCw { get; set; }

    /// <summary>
    /// 國中
    /// </summary>
    public bool GuoJungShengCw { get; set; }

    /// <summary>
    /// 國小
    /// </summary>
    public bool GuoShiauShengCw { get; set; }

    /// <summary>
    /// 狀態改變時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 大學部狀態改變者 ID
    /// </summary>
    public int Auth001Id { get; set; }
}

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl009
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl004 舊碩博士班 ID
    /// </summary>
    public int OldSchoolCtrl004Id { get; set; }

    /// <summary>
    /// FK State002 系科所狀態 ID
    /// </summary>
    public int State002Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl004 新碩博士班 ID
    /// </summary>
    public int? NewSchoolCtrl004Id { get; set; }

    /// <summary>
    /// 舊碩博班系所名稱
    /// </summary>
    public string? OldShuoBoShrBanName { get; set; }

    /// <summary>
    /// 舊班名稱
    /// </summary>
    public string? OldClassName { get; set; }

    /// <summary>
    /// 舊組名稱
    /// </summary>
    public string? OldGroupName { get; set; }

    /// <summary>
    /// 碩博班狀態改變年度
    /// </summary>
    public string Year { get; set; } = null!;

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    /// <summary>
    /// 博士班可填報(0:否,1:是)
    /// </summary>
    public bool BoShiBanCw { get; set; }

    /// <summary>
    /// 碩士班可填報 can write
    /// </summary>
    public bool ShuoShiBanCw { get; set; }

    /// <summary>
    /// 碩士在職專班可填報
    /// </summary>
    public bool ShuoShiZaiZhiZhuanBanCw { get; set; }

    /// <summary>
    /// 碩博班狀態建立時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 專科招生建立者ID
    /// </summary>
    public int Auth001Id { get; set; }
}

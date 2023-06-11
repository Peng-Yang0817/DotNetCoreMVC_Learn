using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneSchoolState
{
    /// <summary>
    /// PK 一階申請狀態 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// FK 學校 編碼
    /// </summary>
    public int SchoolCtrl001Id { get; set; }

    /// <summary>
    /// FK 申請狀態 編碼
    /// </summary>
    public int OneFormStateId { get; set; }

    /// <summary>
    /// 學校備註
    /// </summary>
    public string? Ps1 { get; set; }

    /// <summary>
    /// 總量to學校備註
    /// </summary>
    public string? Ps2 { get; set; }

    /// <summary>
    /// 總量備註
    /// </summary>
    public string? Ps3 { get; set; }

    /// <summary>
    /// 創建/修改時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK 創建/修改者 編碼
    /// </summary>
    public int EditAuth001Id { get; set; }
}

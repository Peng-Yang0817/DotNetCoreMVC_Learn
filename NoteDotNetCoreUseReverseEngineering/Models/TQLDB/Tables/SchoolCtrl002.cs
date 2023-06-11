using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl002
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 學院名稱
    /// </summary>
    public string CollegeName { get; set; } = null!;

    /// <summary>
    /// FK SchoolCtrl001 學校代碼
    /// </summary>
    public int SchoolCtrl001Id { get; set; }

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    /// <summary>
    /// 學院建立時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 學院建立者
    /// </summary>
    public int Auth001Id { get; set; }
}

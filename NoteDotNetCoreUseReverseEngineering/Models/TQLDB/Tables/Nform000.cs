using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform000
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl001 學校ID
    /// </summary>
    public int SchoolCtrl001Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// FK State001 狀態Id
    /// </summary>
    public int State001Id { get; set; }

    /// <summary>
    /// 學校備註
    /// </summary>
    public string? SchoolNote { get; set; }

    /// <summary>
    /// 總量備註
    /// </summary>
    public string? TotalNote { get; set; }

    /// <summary>
    /// 教育部備註
    /// </summary>
    public string? EduNote { get; set; }

    /// <summary>
    /// FK Auth001 填寫者Id
    /// </summary>
    public int Auth001Id { get; set; }

    /// <summary>
    /// 記錄時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

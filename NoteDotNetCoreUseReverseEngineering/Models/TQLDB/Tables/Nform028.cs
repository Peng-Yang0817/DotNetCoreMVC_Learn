using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform028
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 學年期
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// FK State003 ID 學制代碼
    /// </summary>
    public int State003Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl007 ID 五專系所代碼
    /// </summary>
    public int SchoolCtrl007Id { get; set; }

    /// <summary>
    /// 雙軌招生名額
    /// </summary>
    public int ShuangGuiJqs { get; set; }

    /// <summary>
    /// FK Auth001 填寫者
    /// </summary>
    public int Auth001Id { get; set; }

    /// <summary>
    /// 紀錄時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

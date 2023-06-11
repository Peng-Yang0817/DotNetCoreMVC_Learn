using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform030
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 學年期
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// FK State003 ID 學制代碼
    /// </summary>
    public int State003Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl007 ID 五專系所代碼
    /// </summary>
    public int SchoolCtrl007Id { get; set; }

    /// <summary>
    /// 計畫核定學年度
    /// </summary>
    public int ProjectYear { get; set; }

    /// <summary>
    /// 計畫編號
    /// </summary>
    public string ProjectNum { get; set; } = null!;

    /// <summary>
    /// 教育部核定文號
    /// </summary>
    public string DocNum { get; set; } = null!;

    /// <summary>
    /// 專班名稱
    /// </summary>
    public string ClassName { get; set; } = null!;

    /// <summary>
    /// 攜手計畫之招生名額
    /// </summary>
    public int XiShouJqs { get; set; }

    /// <summary>
    /// FK Auth001 填寫者
    /// </summary>
    public int Auth001Id { get; set; }

    /// <summary>
    /// 紀錄時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

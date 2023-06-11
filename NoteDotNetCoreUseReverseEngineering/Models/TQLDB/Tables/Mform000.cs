using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform000
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK MForm001 Id 匯入報表
    /// </summary>
    public int Mform001Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// FK Auth001 Id 匯入者
    /// </summary>
    public int Auth001Id { get; set; }

    /// <summary>
    /// 匯入時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

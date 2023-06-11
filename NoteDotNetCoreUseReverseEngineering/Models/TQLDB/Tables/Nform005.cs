using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform005
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
    /// FK SchoolCtrl004 ID 系所代碼
    /// </summary>
    public int SchoolCtrl004Id { get; set; }

    /// <summary>
    /// 碩士班招生名額
    /// </summary>
    public int ShuoShiBanJqs { get; set; }

    /// <summary>
    /// 寄存名額
    /// </summary>
    public int Deposit { get; set; }

    /// <summary>
    /// 寄存回復名額
    /// </summary>
    public int DepositRecover { get; set; }

    /// <summary>
    /// FK Auth001 填寫者
    /// </summary>
    public int Auth001Id { get; set; }

    /// <summary>
    /// 紀錄時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

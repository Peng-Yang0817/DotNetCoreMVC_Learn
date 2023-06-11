using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform033
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// FK SchoolCtrl007 Id 系所代碼
    /// </summary>
    public int SchoolCtrl007Id { get; set; }

    /// <summary>
    /// 甄選管道招生名額缺額(總量填寫)
    /// </summary>
    public int TolalShortfall { get; set; }

    /// <summary>
    /// 招生名額再次寄存(學校填寫)
    /// </summary>
    public int AgainDeposit { get; set; }

    /// <summary>
    /// 創建者
    /// </summary>
    public int Auth001Id { get; set; }

    /// <summary>
    /// 創建時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

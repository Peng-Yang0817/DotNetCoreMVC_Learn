using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Auth003
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK Auth001Id
    /// </summary>
    public int? Auth001Id { get; set; }

    /// <summary>
    /// 登入錯誤次數
    /// </summary>
    public int Cou { get; set; }

    /// <summary>
    /// 封鎖的登入IP
    /// </summary>
    public string? LockIp { get; set; }

    /// <summary>
    /// 封鎖時間
    /// </summary>
    public DateTime? LockTime { get; set; }
}

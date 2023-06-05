using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Auth002
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK Auth001Id
    /// </summary>
    public int Auth001Id { get; set; }

    /// <summary>
    /// 最近一次被修改的密碼
    /// </summary>
    public string? Password1 { get; set; }

    /// <summary>
    /// 第二次被修改的密碼
    /// </summary>
    public string? Password2 { get; set; }

    /// <summary>
    /// 第三次被修改的密碼
    /// </summary>
    public string? Password3 { get; set; }

    /// <summary>
    /// 密碼修改期限
    /// </summary>
    public DateTime? ChangePwdeadline { get; set; }

    public DateTime? ChangePwtime { get; set; }
}

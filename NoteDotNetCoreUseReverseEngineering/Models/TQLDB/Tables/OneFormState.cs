using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneFormState
{
    /// <summary>
    /// PK 一階表單狀態 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 一階表單狀態 名稱
    /// </summary>
    public string FormStateName { get; set; } = null!;
}

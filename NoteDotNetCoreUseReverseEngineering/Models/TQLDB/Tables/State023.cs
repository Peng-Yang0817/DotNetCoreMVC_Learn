using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State023
{
    public int Id { get; set; }

    /// <summary>
    /// 博士班申請類別
    /// </summary>
    public string ApplicationCategory { get; set; } = null!;
}

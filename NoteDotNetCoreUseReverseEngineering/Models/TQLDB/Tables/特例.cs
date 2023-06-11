using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class 特例
{
    public int Id { get; set; }

    public int? 學校代碼 { get; set; }

    public string? 學校名稱 { get; set; }

    public string? 系所類別 { get; set; }

    public string? 系所代碼 { get; set; }

    public string? 系所名稱 { get; set; }

    public string? 學制代碼 { get; set; }

    public string? 學制名稱 { get; set; }

    public int? 年級 { get; set; }

    /// <summary>
    /// 篩選結果須為&quot;1&quot;
    /// </summary>
    public bool? 篩選結果 { get; set; }
}

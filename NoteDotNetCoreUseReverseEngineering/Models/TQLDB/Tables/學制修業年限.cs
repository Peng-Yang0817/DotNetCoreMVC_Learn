using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class 學制修業年限
{
    public int Id { get; set; }

    public string? 學制代碼 { get; set; }

    public string? 學制名稱 { get; set; }

    public int? 年級 { get; set; }

    public string? 是否符合畢業生條件 { get; set; }

    public int? 一般生 { get; set; }

    public string? 是否符合延畢生條件 { get; set; }

    public int? 一般生刪除 { get; set; }
}

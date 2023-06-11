using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Oe領域
{
    public int Id { get; set; }

    public int? 學年度 { get; set; }

    public string? 學期 { get; set; }

    public int? 學校代碼 { get; set; }

    public string? 學校名稱 { get; set; }

    public string? 學院名稱 { get; set; }

    public string? 系所類別代碼 { get; set; }

    public string? 系所類別 { get; set; }

    public int? 系所代碼 { get; set; }

    public string? 系所名稱 { get; set; }

    public string? 學制代碼 { get; set; }

    public string? 學制名稱 { get; set; }

    public int? 年級 { get; set; }

    public string? 領域類型原oe { get; set; }
}

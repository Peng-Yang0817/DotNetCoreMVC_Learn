using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Statistics007
{
    public long? RowId { get; set; }

    public int Id { get; set; }

    public string 學年度 { get; set; } = null!;

    public string 學校代碼 { get; set; } = null!;

    public string 學校名稱 { get; set; } = null!;

    public string 院名稱 { get; set; } = null!;

    public string? 系所名稱 { get; set; }

    public string 招生類別 { get; set; } = null!;

    public int 寄存名額 { get; set; }

    public string 系所類別 { get; set; } = null!;
}

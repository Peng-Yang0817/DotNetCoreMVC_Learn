using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewTt1142
{
    public int 學年度 { get; set; }

    public string 學期 { get; set; } = null!;

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public int? 兼任教師教授 { get; set; }

    public int? 兼任教師副教授 { get; set; }

    public int? 兼任教師助理教授 { get; set; }

    public int? 兼任教師講師 { get; set; }
}

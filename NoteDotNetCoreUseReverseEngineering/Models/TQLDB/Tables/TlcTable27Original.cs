using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable27Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string 系所類別代碼 { get; set; } = null!;

    public int 系所代碼 { get; set; }

    public string 系所名稱 { get; set; } = null!;

    public string 學制代碼 { get; set; } = null!;

    public string 學制名稱 { get; set; } = null!;

    public int 保留學籍學生人數 { get; set; }

    public int 非高中生申請入學保留學籍 { get; set; }

    public int 高中生申請入學保留學籍 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

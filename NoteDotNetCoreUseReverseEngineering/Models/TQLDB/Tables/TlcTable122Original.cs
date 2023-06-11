using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable122Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public string 學期 { get; set; } = null!;

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public int 系所代碼 { get; set; }

    public string 系所名稱 { get; set; } = null!;

    public int 教師識別碼 { get; set; }

    public string 教師姓名 { get; set; } = null!;

    public string 證照類型 { get; set; } = null!;

    public string 證照名稱 { get; set; } = null!;

    public string 發照機構 { get; set; } = null!;

    public string? 證照字號 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

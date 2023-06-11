using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable423Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public string 學期 { get; set; } = null!;

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string 學院名稱 { get; set; } = null!;

    public string 系所類別 { get; set; } = null!;

    public int 系所代碼 { get; set; }

    public string 系所名稱 { get; set; } = null!;

    public string 學制代碼 { get; set; } = null!;

    public string 學制名稱 { get; set; } = null!;

    public string 領域類型 { get; set; } = null!;

    public int 年級 { get; set; }

    public string 身分類別 { get; set; } = null!;

    public string 國家地區代碼 { get; set; } = null!;

    public string 國家地區 { get; set; } = null!;

    public int 依就學辦法入學男 { get; set; }

    public int 依就學辦法入學女 { get; set; }

    public int 依一般身分入學男 { get; set; }

    public int 依一般身分入學女 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public int? 男女 { get; set; }
}

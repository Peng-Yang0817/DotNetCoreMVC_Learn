using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable115Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public string 學期 { get; set; } = null!;

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string 系所名稱 { get; set; } = null!;

    public string 等級 { get; set; } = null!;

    public string 國家地區代碼 { get; set; } = null!;

    public string 國家地區 { get; set; } = null!;

    public int 男 { get; set; }

    public int 女 { get; set; }

    public string 是否支領彈性薪資 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

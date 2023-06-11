using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable213Original
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

    public string 招生方式 { get; set; } = null!;

    public int 核定名額 { get; set; }

    public int 註冊人數男 { get; set; }

    public int 註冊人數女 { get; set; }

    public int? 增額錄取註冊人數男 { get; set; }

    public int? 增額錄取註冊人數女 { get; set; }

    public string? 公文日期 { get; set; }

    public string? 公文字號 { get; set; }

    public string? 備註 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

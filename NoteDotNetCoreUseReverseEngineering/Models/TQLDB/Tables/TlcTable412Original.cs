using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable412Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string 學院名稱 { get; set; } = null!;

    public string 系所類別代碼 { get; set; } = null!;

    public string 系所類別 { get; set; } = null!;

    public int 系所代碼 { get; set; }

    public string 系所名稱 { get; set; } = null!;

    public string 學制代碼 { get; set; } = null!;

    public string 學制名稱 { get; set; } = null!;

    public string 身份類別 { get; set; } = null!;

    public string 僑居地國別地區省別 { get; set; } = null!;

    public decimal 畢業生男 { get; set; }

    public decimal 畢業生女 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable16Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public string 學期 { get; set; } = null!;

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public int 系所代碼 { get; set; }

    public string 系所名稱 { get; set; } = null!;

    public int 教師識別號 { get; set; }

    public string 教師姓名 { get; set; } = null!;

    public string 服務單位or服務廠商 { get; set; } = null!;

    public string 服務性質 { get; set; } = null!;

    public string? 服務名稱 { get; set; }

    public string 是否具簽約文件 { get; set; } = null!;

    public string? 案號 { get; set; }

    public string? 案名 { get; set; }

    public string 服務內容是否與教師專業技能相關 { get; set; } = null!;

    public string? 簽約服務起始日 { get; set; }

    public string? 簽約服務結束日 { get; set; }

    public decimal? 每件簽約時數 { get; set; }

    public decimal? 每件簽約回饋金 { get; set; }

    public string? 備註 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

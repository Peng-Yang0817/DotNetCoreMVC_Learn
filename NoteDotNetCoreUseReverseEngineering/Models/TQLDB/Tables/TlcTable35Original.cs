using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable35Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public string 學期 { get; set; } = null!;

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string 當期課號 { get; set; } = null!;

    public string 課程名稱 { get; set; } = null!;

    public string 開課系所類別 { get; set; } = null!;

    public string 系所類別 { get; set; } = null!;

    public int 開課系所代碼 { get; set; }

    public string 開課系所 { get; set; } = null!;

    public string 開課學制代碼 { get; set; } = null!;

    public string 開課學制 { get; set; } = null!;

    public string 科目類別 { get; set; } = null!;

    public string 修別 { get; set; } = null!;

    public decimal 課程時數 { get; set; }

    public decimal 實習時數 { get; set; }

    public decimal 開課學分數 { get; set; }

    public string? 第一次上課日期 { get; set; }

    public int 教師識別號 { get; set; }

    public string 授課教師 { get; set; } = null!;

    public decimal 授課時數 { get; set; }

    public int 修課人數男 { get; set; }

    public int 修課人數女 { get; set; }

    public string 主要授課語言 { get; set; } = null!;

    public string 畢業班課程 { get; set; } = null!;

    public string 寒暑別 { get; set; } = null!;

    public string 全程使用外語 { get; set; } = null!;

    public string 是否符合專業英語課程 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

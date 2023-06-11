using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable15Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public string 學期 { get; set; } = null!;

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string 是否為教育部全部授權自審學校 { get; set; } = null!;

    public int 系所代碼 { get; set; }

    public string 系所名稱 { get; set; } = null!;

    public int 教師識別號 { get; set; }

    public string 教師姓名 { get; set; } = null!;

    public string 升等等級 { get; set; } = null!;

    public string 升等類型 { get; set; } = null!;

    public string 升等狀態 { get; set; } = null!;

    public string 學校發文字號證書字號 { get; set; } = null!;

    public string 年資起算日期 { get; set; } = null!;

    public string 證書核發日期 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

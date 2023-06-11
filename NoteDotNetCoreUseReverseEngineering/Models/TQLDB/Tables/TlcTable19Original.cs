using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable19Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public int 系所代碼 { get; set; }

    public string 系所名稱 { get; set; } = null!;

    public int 教師識別號 { get; set; }

    public string 教師姓名 { get; set; } = null!;

    public string 論文名稱 { get; set; } = null!;

    public string? 收錄分類 { get; set; }

    public string 作者順序 { get; set; } = null!;

    public string 通訊作者 { get; set; } = null!;

    public string? 刊物名稱 { get; set; }

    public string? 發表卷數 { get; set; }

    public string 是否具有審稿制度 { get; set; } = null!;

    public string? 發表期數 { get; set; }

    public string 期刊出版地國家or地區 { get; set; } = null!;

    public int 發表月份 { get; set; }

    public int 發表年份 { get; set; }

    public string 發表形式 { get; set; } = null!;

    public string? 所屬計畫案 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

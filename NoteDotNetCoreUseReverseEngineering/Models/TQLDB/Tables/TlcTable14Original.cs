using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable14Original
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

    public string 進修項目 { get; set; } = null!;

    public string 進修學校機構 { get; set; } = null!;

    public string 進修系所 { get; set; } = null!;

    public string? 進修課程 { get; set; }

    public string? 主修領域 { get; set; }

    public string 進修時間 { get; set; } = null!;

    public decimal? 進修時數 { get; set; }

    public string 學校辦理方式 { get; set; } = null!;

    public string 進修地區 { get; set; } = null!;

    public string 地區名稱 { get; set; } = null!;

    public string 補助來源 { get; set; } = null!;

    public string 補助情形 { get; set; } = null!;

    public string 補助金額項目 { get; set; } = null!;

    public string 進修狀態 { get; set; } = null!;

    public string? 證書字號 { get; set; }

    public string 進修日期 { get; set; } = null!;

    public string? 完成日期 { get; set; }

    public string 校內簽約 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

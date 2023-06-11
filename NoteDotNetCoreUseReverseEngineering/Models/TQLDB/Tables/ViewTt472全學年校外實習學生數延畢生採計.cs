using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewTt472全學年校外實習學生數延畢生採計
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string 學院名稱 { get; set; } = null!;

    public string 系所類別 { get; set; } = null!;

    public int 系所代碼 { get; set; }

    public string 系所名稱 { get; set; } = null!;

    public string 學制代碼 { get; set; } = null!;

    public string 學制名稱 { get; set; } = null!;

    public int 年級 { get; set; }

    public string 是否符合延畢生條件 { get; set; } = null!;

    public int 全學年全部學分總人數男 { get; set; }

    public int 全學年全部學分總人數女 { get; set; }

    public int 全學年全部學分總時數 { get; set; }

    public int 繁星菁英入學人數男 { get; set; }

    public int 繁星菁英入學人數女 { get; set; }

    public int 外籍生人數男 { get; set; }

    public int 外籍生人數女 { get; set; }

    public int 全學年全部學分實習必修 { get; set; }

    public int 全學年全部學分實習選修 { get; set; }

    public string 期間 { get; set; } = null!;

    public int 部分實習學分人次男 { get; set; }

    public int 部分實習學分人次女 { get; set; }

    public int 部分學分實習總時數 { get; set; }

    public int 部分學生實習學分數必修 { get; set; }

    public int 部分學生實習學分數選修 { get; set; }

    public string 實習期間 { get; set; } = null!;

    public string 實習場所 { get; set; } = null!;

    public string 實習國家地區代碼 { get; set; } = null!;

    public string 實習國家地區 { get; set; } = null!;

    public string 佐證資料 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public int? 男女 { get; set; }
}

﻿using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewTt428
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

    public int 總人數本國籍男 { get; set; }

    public int 總人數本國籍女 { get; set; }

    public int 總人數外國籍男 { get; set; }

    public int 總人數外國籍女 { get; set; }

    public int 繁星菁英入學總人數本國籍男 { get; set; }

    public int 繁星菁英入學總人數本國籍女 { get; set; }

    public int 繁星菁英入學總人數外國籍男 { get; set; }

    public int 繁星菁英入學總人數外國籍女 { get; set; }

    public string? 計算時領域類型 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

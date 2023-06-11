using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable11Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public string 學期 { get; set; } = null!;

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string 系所類別代碼 { get; set; } = null!;

    public string 系所類別 { get; set; } = null!;

    public int 主聘系所代碼 { get; set; }

    public string 主聘系所 { get; set; } = null!;

    public string 身分識別種類 { get; set; } = null!;

    public string 身分識別號 { get; set; } = null!;

    public string 國籍 { get; set; } = null!;

    public int 教師識別號 { get; set; }

    public string 中文姓名 { get; set; } = null!;

    public string? 英文姓名 { get; set; }

    public string 性別 { get; set; } = null!;

    public string 出生年月日 { get; set; } = null!;

    public string 專任教師是否為原住民籍 { get; set; } = null!;

    public string? 族籍別 { get; set; }

    public string 共聘系所代碼 { get; set; } = null!;

    public string 共聘系所 { get; set; } = null!;

    public string 電子郵件 { get; set; } = null!;

    public string 任職狀態 { get; set; } = null!;

    public string? 聘任日期 { get; set; }

    public string? 最早到校日 { get; set; }

    public string? 原任單位 { get; set; }

    public string? 離職日期 { get; set; }

    public string? 新任單位 { get; set; }

    public string? 停職日期 { get; set; }

    public string? 復職日期 { get; set; }

    public string 編制內外 { get; set; } = null!;

    public string 專兼任 { get; set; } = null!;

    public string 專兼職業別 { get; set; } = null!;

    public string? 專兼職單位 { get; set; }

    public string? 專兼職職務 { get; set; }

    public string 借調否 { get; set; } = null!;

    public string? 借調目的來源 { get; set; }

    public string? 借調新單位 { get; set; }

    public string 兼任行政工作 { get; set; } = null!;

    public string? 行政工作職務 { get; set; }

    public string 最高學歷學校 { get; set; } = null!;

    public string 最高學歷系所 { get; set; } = null!;

    public string 最高學歷學位 { get; set; } = null!;

    public string 學術專長及研究 { get; set; } = null!;

    public string 教師分類 { get; set; } = null!;

    public string 聘書職級 { get; set; } = null!;

    public string? 聘約是否達一年以上 { get; set; }

    public string 證書職級 { get; set; } = null!;

    public string? 聘書字號 { get; set; }

    public string? 證書字號 { get; set; }

    public string? 證照公文字號 { get; set; }

    public string? 校教評會字號 { get; set; }

    public string 是否支領彈性薪資 { get; set; } = null!;

    public string 是否第一次任專任助理教授 { get; set; } = null!;

    public string? 兼任教師是否具本全職工作者 { get; set; }

    public string 是否符合技術及職業教育法第26條適用對象 { get; set; } = null!;

    public string? 印領清冊頁碼 { get; set; }

    public decimal? 兼任教師每周授課時數每週2小時含以上 { get; set; }

    public string 任職兩年且全職進修 { get; set; } = null!;

    public string 編制內是否辦理延長 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

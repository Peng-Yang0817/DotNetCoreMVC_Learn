using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TlcTable83Original
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string RuleYnCn { get; set; } = null!;

    public string 機構或公司業主 { get; set; } = null!;

    public string 建築名稱 { get; set; } = null!;

    public string? 縣市別 { get; set; }

    public string 合約有無經法院公證 { get; set; } = null!;

    public string 法院公證證明字號 { get; set; } = null!;

    public string 教育部核定文號 { get; set; } = null!;

    public decimal 床位數男 { get; set; }

    public decimal 床位數女 { get; set; }

    public decimal 收費標準最高 { get; set; }

    public decimal 收費標準最低 { get; set; }

    public decimal 租金平均標準男 { get; set; }

    public decimal 租金平均標準女 { get; set; }

    public decimal 所有權狀面積 { get; set; }

    public decimal 使用執照面積 { get; set; }

    public string 有無合約 { get; set; } = null!;

    public string 租約開始日期 { get; set; } = null!;

    public string 租約結束日期 { get; set; } = null!;

    public string? 備註 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}

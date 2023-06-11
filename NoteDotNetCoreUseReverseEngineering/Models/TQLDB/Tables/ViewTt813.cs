using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewTt813
{
    public int Id { get; set; }

    public int 學年度 { get; set; }

    public string 學期 { get; set; } = null!;

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string 縣市別代碼 { get; set; } = null!;

    public string 縣市別 { get; set; } = null!;

    public string 校區 { get; set; } = null!;

    public string 狀態 { get; set; } = null!;

    public string 興建狀況 { get; set; } = null!;

    public string 使用執照取得情形 { get; set; } = null!;

    public string 租賃宿舍是否符合土地使用分區管制規定 { get; set; } = null!;

    public string 校舍建築名稱 { get; set; } = null!;

    public string? 基地地號 { get; set; }

    public string 權屬別 { get; set; } = null!;

    public string 出租借情況 { get; set; } = null!;

    public string 建築樓層數扣除地下樓層 { get; set; } = null!;

    public string 建築樓層數地下樓層 { get; set; } = null!;

    public decimal 所有權狀之樓地板面積不含地下室 { get; set; }

    public decimal 所有權狀之地下室樓地板面積 { get; set; }

    public decimal 所有權狀面積 { get; set; }

    public decimal 使用執照之樓地板面積不含地下室 { get; set; }

    public decimal 使用執照之地下室樓地板面積 { get; set; }

    public decimal 使用執照總面積 { get; set; }

    public string? 地方建管單位開立合法建築證明文件及文號 { get; set; }

    public string? 地方建管單位開立合法使用執照文號 { get; set; }

    public string 建物安全鑑定通過情形 { get; set; } = null!;

    public string? 完工日期 { get; set; }

    public decimal? 學生宿舍 { get; set; }

    public decimal? 學校附屬機構 { get; set; }

    public decimal? 其他提供予正式學籍學生活動教學研究之使用校舍建築 { get; set; }

    public decimal? 專供推廣教育使用 { get; set; }

    public decimal? 對外營業者 { get; set; }

    public decimal? 無須申請建築執照之房舍 { get; set; }

    public decimal? 僅需申請雜項執照之地上改良物 { get; set; }

    public decimal? 明顯與學生活動教學研究無關者 { get; set; }

    public decimal? 教職員宿舍包含教職員宿舍學人宿舍校長宿舍等 { get; set; }

    public string? 其他 { get; set; }

    public decimal? 其他面積 { get; set; }

    public string? 備註 { get; set; }

    public decimal? 面積數採計 { get; set; }
}

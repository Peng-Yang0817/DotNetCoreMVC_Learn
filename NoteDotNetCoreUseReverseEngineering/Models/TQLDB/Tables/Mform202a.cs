using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform202a
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// 學期
    /// </summary>
    public string? Semester { get; set; }

    /// <summary>
    /// 校基庫學校代碼
    /// </summary>
    public string SchoolNum { get; set; } = null!;

    /// <summary>
    /// 學校名稱
    /// </summary>
    public string SchoolName { get; set; } = null!;

    /// <summary>
    /// 校區(校本部、分部)
    /// </summary>
    public string? Campus { get; set; }

    /// <summary>
    /// 校舍建築名稱
    /// </summary>
    public string? BuildingName { get; set; }

    /// <summary>
    /// 狀態(已完成)
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 完工日期
    /// </summary>
    public string? FinishDate { get; set; }

    /// <summary>
    /// 使用執照取得情形
    /// </summary>
    public string? UseLicense { get; set; }

    /// <summary>
    /// 建物安全鑑定通過情形(結構與消防均有)
    /// </summary>
    public string? SafeSituation { get; set; }

    /// <summary>
    /// 權屬別(自有)
    /// </summary>
    public string? Ownership { get; set; }

    /// <summary>
    /// 出租(借)情形
    /// </summary>
    public string? Rent { get; set; }

    /// <summary>
    /// 面積數-提供正式學籍學生活動、教學、研究之用
    /// </summary>
    public double? AreaNum { get; set; }

    /// <summary>
    /// 修改項目(增加、修改(刪除))
    /// </summary>
    public string? EditNote { get; set; }

    /// <summary>
    /// 修改說明
    /// </summary>
    public string? Note { get; set; }

    public DateTime EditTime { get; set; }
}

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform103a
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
    public string Semester { get; set; } = null!;

    /// <summary>
    /// 校基庫學校代碼
    /// </summary>
    public string SchoolNum { get; set; } = null!;

    /// <summary>
    /// 學校名稱
    /// </summary>
    public string SchoolName { get; set; } = null!;

    /// <summary>
    /// 系所代碼
    /// </summary>
    public string DepartmentNum { get; set; } = null!;

    /// <summary>
    /// 系所名稱
    /// </summary>
    public string DepartmentName { get; set; } = null!;

    /// <summary>
    /// 學制
    /// </summary>
    public string? Degree { get; set; }

    /// <summary>
    /// 第幾年
    /// </summary>
    public string? DiJiNian { get; set; }

    /// <summary>
    /// 類別
    /// </summary>
    public string? Categy { get; set; }

    /// <summary>
    /// 在學學生數
    /// </summary>
    public int? InSchoolStudent { get; set; }

    /// <summary>
    /// 全學年校外實習學生數
    /// </summary>
    public int? QuanXueXiaoWaiShiXiXueShengShu { get; set; }

    /// <summary>
    /// 修改項目
    /// </summary>
    public string EditNote { get; set; } = null!;

    /// <summary>
    /// 修改註記
    /// </summary>
    public string Note { get; set; } = null!;

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

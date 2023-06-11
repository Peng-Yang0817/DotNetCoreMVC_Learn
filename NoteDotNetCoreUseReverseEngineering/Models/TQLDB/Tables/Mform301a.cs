using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform301a
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
    /// 主聘系所
    /// </summary>
    public string? ZhuPinXiSuo { get; set; }

    /// <summary>
    /// 教師識別號
    /// </summary>
    public string? TeacherNum { get; set; }

    /// <summary>
    /// 教師姓名(中文)
    /// </summary>
    public string? TeacherName { get; set; }

    /// <summary>
    /// 共聘系所
    /// </summary>
    public string? GongPinXiSuo { get; set; }

    /// <summary>
    /// 聘任日期
    /// </summary>
    public string? PinRenDate { get; set; }

    /// <summary>
    /// 專、兼任
    /// </summary>
    public string? JuanJianRen { get; set; }

    /// <summary>
    /// 兼任教師每週授課時數(每週2小時(含)以上)
    /// </summary>
    public string? ShouKeShiShu { get; set; }

    /// <summary>
    /// 教師分類
    /// </summary>
    public string? Classification { get; set; }

    /// <summary>
    /// 是否為全時進修教師
    /// </summary>
    public string? JinXiuTeacher { get; set; }

    /// <summary>
    /// 聘書職級(4.30前確定取得職級)
    /// </summary>
    public string? PinShuZhiJi { get; set; }

    /// <summary>
    /// 證書職級(4.30前確定取得職級)
    /// </summary>
    public string? ChengShuZhiJi { get; set; }

    /// <summary>
    /// 證書字號
    /// </summary>
    public string? ChengShuNum { get; set; }

    /// <summary>
    /// 列計職級
    /// </summary>
    public string? LieJiZhiJi { get; set; }

    /// <summary>
    /// 修改項目
    /// </summary>
    public string? EditNote { get; set; }

    /// <summary>
    /// 修改註記
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

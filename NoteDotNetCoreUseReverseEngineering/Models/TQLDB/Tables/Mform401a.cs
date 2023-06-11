using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform401a
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
    /// 開課系所(限學院、學位學程)
    /// </summary>
    public string OpenDepartment { get; set; } = null!;

    /// <summary>
    /// 系所代碼
    /// </summary>
    public string DepartmentNum { get; set; } = null!;

    /// <summary>
    /// 課程名稱
    /// </summary>
    public string? CourseName { get; set; }

    /// <summary>
    /// 開課學制
    /// </summary>
    public string? OpenDegree { get; set; }

    /// <summary>
    /// 科目類別(限專業科目、實習)
    /// </summary>
    public string? SubjetCategy { get; set; }

    /// <summary>
    /// 必選修
    /// </summary>
    public string? BiXuanXiu { get; set; }

    /// <summary>
    /// 教師識別號
    /// </summary>
    public string? TeacherNum { get; set; }

    /// <summary>
    /// 授課教師
    /// </summary>
    public string? TeacherName { get; set; }

    /// <summary>
    /// 專、兼任
    /// </summary>
    public string? JuanJianRen { get; set; }

    /// <summary>
    /// 教師職級
    /// </summary>
    public string? TeacherZhiJi { get; set; }

    /// <summary>
    /// 授課時數(每週)
    /// </summary>
    public double? ShouKeShiShu { get; set; }

    /// <summary>
    /// 開課學分數
    /// </summary>
    public string? KaiKeXueFenShu { get; set; }

    /// <summary>
    /// 教師主聘系所
    /// </summary>
    public string? TeacherZhuPinXiSuo { get; set; }

    /// <summary>
    /// 修改項目
    /// </summary>
    public string? EditNote { get; set; }

    /// <summary>
    /// 修正註記
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

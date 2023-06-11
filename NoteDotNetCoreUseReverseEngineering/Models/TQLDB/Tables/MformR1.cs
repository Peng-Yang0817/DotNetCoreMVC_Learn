using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformR1
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
    /// 校基庫系所代碼
    /// </summary>
    public string DepartmentNum { get; set; } = null!;

    /// <summary>
    /// 系所名稱
    /// </summary>
    public string DepartmentName { get; set; } = null!;

    /// <summary>
    /// 學制
    /// </summary>
    public string Degree { get; set; } = null!;

    /// <summary>
    /// 新生保留入學資格人數（A）
    /// </summary>
    public int? StudentReserved { get; set; }

    /// <summary>
    /// 新生註冊人數（B）
    /// </summary>
    public int StudentEnrollment { get; set; }

    /// <summary>
    /// 核定招生名額（C）
    /// </summary>
    public int ApprovedEnrollment { get; set; }

    /// <summary>
    /// 系所領域別
    /// </summary>
    public string DepartmentAreaName { get; set; } = null!;

    /// <summary>
    /// 醫事管制類系科（對學校不顯示）
    /// </summary>
    public string GuanKongLeiName { get; set; } = null!;

    /// <summary>
    /// 群別（對學校不顯示）
    /// </summary>
    public string Classification { get; set; } = null!;

    /// <summary>
    /// 修改項目(增加、修改(刪除))
    /// </summary>
    public string? EditType { get; set; }

    /// <summary>
    /// 修改註記
    /// </summary>
    public string? EditNote { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

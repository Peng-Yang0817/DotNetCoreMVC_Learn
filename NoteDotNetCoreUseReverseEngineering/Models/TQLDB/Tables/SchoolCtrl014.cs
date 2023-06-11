using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl014
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl001 Id
    /// </summary>
    public int? SchoolCtrl001Id { get; set; }

    /// <summary>
    /// 學校校基庫代碼
    /// </summary>
    public int SchoolNum { get; set; }

    /// <summary>
    /// 總量代碼
    /// </summary>
    public int TotalNum { get; set; }

    /// <summary>
    /// 學校名稱
    /// </summary>
    public string SchoolName { get; set; } = null!;

    /// <summary>
    /// 103學年度全校新生註冊率
    /// </summary>
    public string? OldEnrollment { get; set; }

    /// <summary>
    /// 104學年度全校新生註冊率
    /// </summary>
    public string? NewEnrollment { get; set; }

    /// <summary>
    /// 適用條件(A,B,C)
    /// </summary>
    public string? Conditions { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Note { get; set; }
}

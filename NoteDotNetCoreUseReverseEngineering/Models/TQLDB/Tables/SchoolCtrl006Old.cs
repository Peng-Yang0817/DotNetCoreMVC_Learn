using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl006Old
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 高中申請系名稱
    /// </summary>
    public string GauJungBuName { get; set; } = null!;

    /// <summary>
    /// FK SchoolCtrl001 學校代碼
    /// </summary>
    public int? SchoolCtrl001Id { get; set; }

    /// <summary>
    /// 高中申請班別名稱
    /// </summary>
    public string? ClassName { get; set; }

    /// <summary>
    /// 高中申請群別名稱
    /// </summary>
    public string? GroupName { get; set; }

    /// <summary>
    /// 高中申請類別(未用)
    /// </summary>
    public string? CategoryName { get; set; }

    /// <summary>
    /// FK SchoolCtrl003 領域別ID
    /// </summary>
    public int SchoolCtrl003Id { get; set; }

    /// <summary>
    /// 校基庫系所代碼
    /// </summary>
    public string? DepartmentNum { get; set; }

    /// <summary>
    /// FK State005 管制類ID
    /// </summary>
    public int? State005Id { get; set; }

    /// <summary>
    /// 高中申請建立時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 高中申請建立者
    /// </summary>
    public int Auth001Id { get; set; }
}

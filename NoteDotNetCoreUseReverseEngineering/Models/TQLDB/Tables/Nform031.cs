using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform031
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
    /// 校碼
    /// </summary>
    public string? SchoolNum { get; set; }

    /// <summary>
    /// 學校
    /// </summary>
    public string? SchoolName { get; set; }

    /// <summary>
    /// 校基庫系所代碼
    /// </summary>
    public string? DepartmentNum { get; set; }

    /// <summary>
    /// 調整別
    /// </summary>
    public string? Revision { get; set; }

    /// <summary>
    /// 系所名稱
    /// </summary>
    public string? DepartmentName { get; set; }

    /// <summary>
    /// 開設學制
    /// </summary>
    public string? NewJqs { get; set; }

    /// <summary>
    /// 既有學制
    /// </summary>
    public string? CurrentJqs { get; set; }

    /// <summary>
    /// 審核結果
    /// </summary>
    public string? Results { get; set; }

    /// <summary>
    /// 領域別
    /// </summary>
    public string? AreaName { get; set; }

    /// <summary>
    /// 群別
    /// </summary>
    public string? Classification { get; set; }

    /// <summary>
    /// 醫事管制類系科
    /// </summary>
    public string? GuanKongLeiName { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? UserNote { get; set; }
}

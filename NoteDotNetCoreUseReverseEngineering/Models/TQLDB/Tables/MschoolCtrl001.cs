using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MschoolCtrl001
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 資料庫代碼
    /// </summary>
    public string? SchoolNum { get; set; }

    /// <summary>
    /// 校碼
    /// </summary>
    public string? DbNum { get; set; }

    /// <summary>
    /// 校名
    /// </summary>
    public string? SchoolName { get; set; }

    /// <summary>
    /// 公私立public and private
    /// </summary>
    public string? Pap { get; set; }

    /// <summary>
    /// 校院類型tapes of school
    /// </summary>
    public string? Tos { get; set; }

    /// <summary>
    /// 最近一次改名、改制時間
    /// </summary>
    public string? RecentTime { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 縣市別
    /// </summary>
    public string? CityArea { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Note { get; set; }
}

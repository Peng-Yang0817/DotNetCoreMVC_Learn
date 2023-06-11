using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform001
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 報表代碼
    /// </summary>
    public string? MformNum { get; set; }

    /// <summary>
    /// 匯入報表名稱
    /// </summary>
    public string? MformName { get; set; }

    /// <summary>
    /// URL-Area
    /// </summary>
    public string? Area { get; set; }

    /// <summary>
    /// URL-Controller
    /// </summary>
    public string? Controller { get; set; }

    /// <summary>
    /// URL-Action
    /// </summary>
    public string? Action { get; set; }
}

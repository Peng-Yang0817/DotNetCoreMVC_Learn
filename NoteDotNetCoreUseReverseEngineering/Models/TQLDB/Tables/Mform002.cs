using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform002
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
    /// 輸出報表名稱
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

    /// <summary>
    /// FK MState001 Id
    /// </summary>
    public int? Mstate001Id { get; set; }

    public string? RoleRange { get; set; }
}

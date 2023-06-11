using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SysCtrl002
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 使用者角色名稱
    /// </summary>
    public string RoleName { get; set; } = null!;

    /// <summary>
    /// 使用者角色代碼
    /// </summary>
    public string RoleRange { get; set; } = null!;

    /// <summary>
    /// 使用者可用menu
    /// </summary>
    public string? HaveMenu { get; set; }

    /// <summary>
    /// 使用者可管理的角色代碼
    /// </summary>
    public string? HaveRange { get; set; }
}

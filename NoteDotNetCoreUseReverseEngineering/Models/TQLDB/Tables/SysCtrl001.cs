using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SysCtrl001
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// menu名稱
    /// </summary>
    public string MenuName { get; set; } = null!;

    public string? Area { get; set; }

    /// <summary>
    /// 程式的control名稱
    /// </summary>
    public string? Controller { get; set; }

    /// <summary>
    /// 程式的Action名稱
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// menu 的 url 位置
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// FK  自己 Id
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// menu 狀態 (開啟,關閉)
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// 目前沒用到
    /// </summary>
    public string? RouteValues { get; set; }

    /// <summary>
    /// 子menu順序(1最小)
    /// </summary>
    public string? OrderSerial { get; set; }

    /// <summary>
    /// 可使用此menu的角色 SysCtrl002 的roleRange
    /// </summary>
    public string? RoleRange { get; set; }

    /// <summary>
    /// menu 可執行時間
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// menu 停止使用時間
    /// </summary>
    public DateTime? EndTime { get; set; }
}

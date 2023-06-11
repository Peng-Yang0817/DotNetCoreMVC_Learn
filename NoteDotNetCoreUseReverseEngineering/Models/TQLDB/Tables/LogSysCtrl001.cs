using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSysCtrl001
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string MenuName { get; set; } = null!;

    public string? Area { get; set; }

    public string? Controller { get; set; }

    public string? Action { get; set; }

    public string? Url { get; set; }

    public int? ParentId { get; set; }

    public string? State { get; set; }

    public string? RouteValues { get; set; }

    public string? OrderSerial { get; set; }

    public string? RoleRange { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime LogTime { get; set; }
}

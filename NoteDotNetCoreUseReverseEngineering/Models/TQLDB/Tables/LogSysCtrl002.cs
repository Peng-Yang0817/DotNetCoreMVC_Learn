using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSysCtrl002
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public string RoleRange { get; set; } = null!;

    public string? HaveMenu { get; set; }

    public string? HaveRange { get; set; }

    public DateTime LogTime { get; set; }
}

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogAuth001
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string RoleRange { get; set; } = null!;

    public int? SchoolCtrl001Id { get; set; }

    public string? Office { get; set; }

    public string? Phone { get; set; }

    public string? Cellphone { get; set; }

    public string? Fax { get; set; }

    public int State006Id { get; set; }

    public DateTime CreateTime { get; set; }

    public bool IsChangeInfo { get; set; }

    public DateTime LogTime { get; set; }
}

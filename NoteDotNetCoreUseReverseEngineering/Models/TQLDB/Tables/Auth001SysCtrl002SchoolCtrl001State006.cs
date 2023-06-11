using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Auth001SysCtrl002SchoolCtrl001State006
{
    public int Auth001Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int State006Id { get; set; }

    public string? StateName { get; set; }

    public string RoleRange { get; set; } = null!;

    public string? RoleName { get; set; }

    public int? SchoolCtrl001Id { get; set; }

    public string? SchoolName { get; set; }

    public string? Tclnum { get; set; }

    public string? SchoolNum { get; set; }

    public DateTime CreateTime { get; set; }
}

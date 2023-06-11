using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Auth001Backup
{
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

    public int? State013Id { get; set; }

    public string? JobTitle { get; set; }

    public string? Specialty { get; set; }

    public string? Education { get; set; }

    public string? Address { get; set; }

    public string? DepartmentName { get; set; }

    public bool? IsChangePassword { get; set; }

    public bool? IsEncrypted { get; set; }
}

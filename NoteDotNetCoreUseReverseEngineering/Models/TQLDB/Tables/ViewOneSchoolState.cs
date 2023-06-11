using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneSchoolState
{
    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public int SchoolCtrl001Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public int OneFormStateId { get; set; }

    public string FormStateName { get; set; } = null!;

    public string? Ps1 { get; set; }

    public string? Ps2 { get; set; }

    public string? Ps3 { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Cellphone { get; set; }

    public DateTime EditTime { get; set; }

    public int EditAuth001Id { get; set; }

    public string EditUsername { get; set; } = null!;

    public string EditName { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogOneSchoolState
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public int SchoolCtrl001Id { get; set; }

    public int OneFormStateId { get; set; }

    public string? Ps1 { get; set; }

    public string? Ps2 { get; set; }

    public string? Ps3 { get; set; }

    public DateTime EditTime { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime LogTime { get; set; }
}

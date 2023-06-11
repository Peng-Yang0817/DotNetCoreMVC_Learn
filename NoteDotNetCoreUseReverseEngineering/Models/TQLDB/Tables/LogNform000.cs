using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogNform000
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public int SchoolCtrl001Id { get; set; }

    public string Year { get; set; } = null!;

    public int State001Id { get; set; }

    public string? SchoolNote { get; set; }

    public string? TotalNote { get; set; }

    public string? EduNote { get; set; }

    public int Auth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public DateTime LogTime { get; set; }
}

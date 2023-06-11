using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogNform029
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public int Year { get; set; }

    public int State003Id { get; set; }

    public int SchoolCtrl005Id { get; set; }

    public int ProjectYear { get; set; }

    public string ProjectNum { get; set; } = null!;

    public string DocNum { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public int XiShouJqs { get; set; }

    public int Auth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public DateTime LogTime { get; set; }
}

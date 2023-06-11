using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SysCtrl004State003004
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string Category { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public int OutDegreeId { get; set; }

    public string OutDegree { get; set; } = null!;

    public int InDegreeId { get; set; }

    public string InDegree { get; set; } = null!;

    public double OutProportion { get; set; }

    public double InProportion { get; set; }

    public string Ps { get; set; } = null!;
}

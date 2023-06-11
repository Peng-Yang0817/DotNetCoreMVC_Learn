using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SysCtrl004
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int OutDegreeId { get; set; }

    public int InDegreeId { get; set; }

    public double OutProportion { get; set; }

    public double InProportion { get; set; }

    public string Ps { get; set; } = null!;
}

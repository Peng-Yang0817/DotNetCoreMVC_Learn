using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSysCtrl004
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int OutDegreeId { get; set; }

    public int InDegreeId { get; set; }

    public double OutProportion { get; set; }

    public double InProportion { get; set; }

    public string Ps { get; set; } = null!;

    public DateTime LogTime { get; set; }
}

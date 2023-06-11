using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogOneForm009
{
    public string Atype { get; set; } = null!;

    public string Id { get; set; } = null!;

    public int SchoolCtrl001Id { get; set; }

    public string Year { get; set; } = null!;

    public string? DepartmentName { get; set; }

    public int? C1 { get; set; }

    public string? C2 { get; set; }

    public string? C3 { get; set; }

    public string? OneFormUploadId { get; set; }

    public DateTime EditTime { get; set; }

    public int EditAuth001 { get; set; }

    public DateTime LogTime { get; set; }
}

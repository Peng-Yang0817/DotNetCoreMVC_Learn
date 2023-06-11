using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogOneFormUpload
{
    public string Atype { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int SchoolCtrl001Id { get; set; }

    public int OneForm000Id { get; set; }

    public string FileName { get; set; } = null!;

    public DateTime EditTime { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime LogTime { get; set; }
}

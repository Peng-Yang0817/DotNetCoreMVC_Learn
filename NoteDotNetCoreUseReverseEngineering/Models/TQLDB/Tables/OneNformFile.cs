using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformFile
{
    public int Id { get; set; }

    public int OneNformTypeId { get; set; }

    public int OneNformId { get; set; }

    public string? FileName1 { get; set; }

    public string? FilePath1 { get; set; }

    public string? FileGuid1 { get; set; }

    public string? FileName2 { get; set; }

    public string? FilePath2 { get; set; }

    public string? FileGuid2 { get; set; }

    public string? FileName3 { get; set; }

    public string? FilePath3 { get; set; }

    public string? FileGuid3 { get; set; }

    public string? FileName4 { get; set; }

    public string? FilePath4 { get; set; }

    public string? FileGuid4 { get; set; }

    public DateTime EditTime { get; set; }

    public int EditAuth001 { get; set; }
}
